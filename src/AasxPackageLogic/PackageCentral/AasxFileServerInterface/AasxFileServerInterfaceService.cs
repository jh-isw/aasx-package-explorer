﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AasxIntegrationBase;
using AdminShellNS;
using IO.Swagger.Api;
using IO.Swagger.Client;
using Microsoft.IdentityModel.Tokens;

namespace AasxPackageLogic.PackageCentral
{
    public class AasxFileServerInterfaceService
    {
        private string _basePath;
        private AASXFileServerInterfaceApi _fileApiInstance;
        private AssetAdministrationShellRepositoryApi _aasApiInstace;

        public AasxFileServerInterfaceService(string basePath)
        {
            try
            {
                _basePath = basePath;

                Configuration configuration = new Configuration
                {
                    BasePath = _basePath
                };
                _fileApiInstance = new AASXFileServerInterfaceApi(configuration);
                _aasApiInstace = new AssetAdministrationShellRepositoryApi(configuration);
            }
            catch (Exception e)
            {
                Log.Singleton.Error(e.Message, "Could not configure ASP.NET file interface");
            }
        }

        //This method retrieved all the packages and corresponsing AASs and Asset related information form the File Server.
        internal List<PackageContainerRepoItem> GeneratePackageRepository()
        {
            var output = new List<PackageContainerRepoItem>();
            try
            {
                var response = _fileApiInstance.GetAllAASXPackageIds();

                foreach (var packageDescription in response)
                {
                    //Get AAS and Asset
                    foreach (var aasId in packageDescription.AasIds)
                    {
                        var aas = _aasApiInstace.GetAssetAdministrationShellById(Base64UrlEncoder.Encode(aasId));
                        if (aas != null)
                        {
                            //Get Asset
                            var asset = _aasApiInstace.GetAssetInformation(Base64UrlEncoder.Encode(aasId));
                            if (asset != null)
                            {
                                var packageContainer = new PackageContainerRepoItem()
                                {
                                    ContainerOptions = PackageContainerOptionsBase.CreateDefault(Options.Curr),
                                    //Location = CombineQuery(_client.BaseAddress.ToString(), _endPointSegments,"server", "getaasx", aasi.Index),
                                    Description = $"\"{"" + aas.idShort}\",\"{"" + asset.idShort}\"",
                                    Tag = "" + AdminShellUtil.ExtractPascalCasingLetters(aas.idShort).SubstringMax(0, 3),
                                    PackageId = packageDescription.PackageId
                                };
                                packageContainer.AasIds.Add("" + aas.identification?.id);
                                packageContainer.AssetIds.Add("" + asset.identification?.id);
                                output.Add(packageContainer);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Log.Singleton.Error(e.Message);
            }

            return output;
        }

        internal int PostAasxFileOnServer(string fileName, byte[] fileContent)
        {
            var aasiIds = new List<string>();

            var response = _fileApiInstance.PostAASXPackageWithHttpInfo(aasiIds, fileContent, fileName);
            if (response.StatusCode == 201)
            {
                return response.Data;
            }
            else
            {
                Log.Singleton.Error($"Uploading AASX File in file repository failed with error {response.StatusCode}");
                return -1;
            }

        }

        internal void DeleteAasxFileFromServer(string packageId)
        {
            try
            {
                var response = _fileApiInstance.DeleteAASXByPackageIdWithHttpInfo(Base64UrlEncoder.Encode(packageId));
                if (response.StatusCode != 204)
                {
                    Log.Singleton.Error($"Delete AASX file from file repository failed with error {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Log.Singleton.Error(ex.Message);
            }
        }

        internal Task PutAasxFileOnServerAsync(string copyFileName, string packageId)
        {
            try
            {
                //TODO (jtikekar, 2022-04-04): aasIds?
                var aasIds = new List<string>();
                var fileContent = File.ReadAllBytes(copyFileName);
                var response = _fileApiInstance.PutAASXByPackageIdWithHttpInfo(aasIds, fileContent, copyFileName, Base64UrlEncoder.Encode(packageId));
                if (response.StatusCode != 204)
                {
                    Log.Singleton.Error($"Update AASX file in file repository failed with error {response.StatusCode}");
                }
            }
            catch (Exception e)
            {
                Log.Singleton.Error(e.Message);
            }

            return Task.CompletedTask;
        }

        internal string LoadAasxPackage(string packageId, PackCntRuntimeOptions runtimeOptions)
        {
            try
            {
                var response = _fileApiInstance.GetAASXByPackageIdWithHttpInfo(Base64UrlEncoder.Encode(packageId));
                if (response != null)
                {
                    if (response.StatusCode == 200)
                    {
                        var fileContent = response.Data;
                        var stream = new MemoryStream(fileContent);
                        response.Headers.TryGetValue("X-FileName", out string fileName);
                        response.Headers.TryGetValue("ContentLength", out string contentLength);
                        long.TryParse(contentLength, out long fileSize);

                        using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            var buffer = new byte[4024];
                            long totalBytes = 0;
                            int currentBlockSize = 0;

                            while ((currentBlockSize = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                totalBytes += currentBlockSize;
                                double percentage = (double)totalBytes * 100.0 / fileSize;

                                file.Write(buffer, 0, currentBlockSize);

                                if (fileSize > totalBytes)
                                {
                                    runtimeOptions?.ProgressChanged?.Invoke(PackCntRuntimeOptions.Progress.Ongoing,
                                    fileSize, totalBytes);
                                }

                                runtimeOptions?.ProgressChanged?.Invoke(PackCntRuntimeOptions.Progress.Final, fileSize, totalBytes);
                                runtimeOptions?.Log?.Info($".. download done with {totalBytes} bytes read!");
                            }

                            file.Close();
                        }

                        return fileName;
                    }
                    else
                    {
                        Log.Singleton.Error($"Doanload AASX File from the server failed with error code: {response.StatusCode}");
                        throw new PackageContainerException($"Server operation not allowed!");
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Singleton.Error(ex.Message);
            }

            //TODO (jtikekar, 2022-04-04): Change
            return null;
        }
    }
}