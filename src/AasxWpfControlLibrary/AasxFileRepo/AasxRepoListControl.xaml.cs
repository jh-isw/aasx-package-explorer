/*
Copyright (c) 2018-2019 Festo AG & Co. KG <https://www.festo.com/net/de_de/Forms/web/contact_international>
Author: Michael Hoffmeister

This source code is licensed under the Apache License 2.0 (see LICENSE.txt).

This source code may use other Open Source software components (see LICENSE.txt).
*/

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using AasxIntegrationBase;
using AasxIntegrationBaseWpf;
using AasxPackageExplorer;
using AasxWpfControlLibrary.PackageCentral;

namespace AasxWpfControlLibrary.AasxFileRepo
{
    public partial class AasxRepoListControl : UserControl
    {
        //
        // External properties
        //

        public event Action<AasxFileRepository, AasxFileRepository.FileItem> FileDoubleClick;
        public event Action<AasxFileRepository, string[]> FileDrop;

        private IFlyoutProvider _flyout;
        private IManageVisualAasxElements _manageVisuElems;
        private AasxRepoList _repoList;

        /// <summary>
        /// Window (handler) which provides flyout control for this control. Is expected to sit in the MainWindow.
        /// Note: only setter, as direct access from outside shall be redirected to the original source.
        /// </summary>
        public IFlyoutProvider FlyoutProvider { set { _flyout = value; } }

        /// <summary>
        /// Handler, which can provide the currently selected visual elements in the AASX tree.
        /// </summary>
        public IManageVisualAasxElements ManageVisuElems { set { _manageVisuElems = value; } }

        /// <summary>
        /// AasxRepoList which is being managed by this control. Is expected to sit in the PackageCentral.
        /// Note: only setter, as direct access from outside shall be redirected to the original source.
        /// </summary>
        public AasxRepoList RepoList {
            get
            {
                return _repoList;
            }
            set 
            { 
                _repoList = value;
                StackPanelRepos.ItemsSource = RepoList;
                this.UpdateLayout();
            }
        }

        //
        // Constructor
        //

        public AasxRepoListControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanelRepos.ItemsSource = RepoList;
        }

        //
        // UI higher-level stuff (taken over and maintained in from MainWindow.CommandBindings.cs)
        //

        public void CommandBinding_FileRepoAll(AasxFileRepository fr, string cmd)
        {
            // access
            if (cmd == null)
                return;
            cmd = cmd.ToLower().Trim();

            // modify list
            if (fr != null && RepoList != null && RepoList.Contains(fr))
            {
                if (cmd == "filerepoclose")
                {
                    if (MessageBoxResult.OK != _flyout.MessageBoxFlyoutShow(
                            "Close file repository? Pending changes might be unsaved!",
                            "AASX File Repository",
                            MessageBoxButton.OKCancel, MessageBoxImage.Hand))
                        return;

                    RepoList.Remove(fr);
                }

                if (cmd == "item-up")
                {
                    int i = RepoList.IndexOf(fr);
                    if (i > 0)
                    {
                        RepoList.RemoveAt(i);
                        RepoList.Insert(i - 1, fr);
                    }
                }

                if (cmd == "item-down")
                {
                    int i = RepoList.IndexOf(fr);
                    if (i < RepoList.Count - 1)
                    {
                        RepoList.RemoveAt(i);
                        RepoList.Insert(i + 1, fr);
                    }
                }

                if (cmd == "filereposaveas")
                {
                    // prepare dialogue
                    var outputDlg = new Microsoft.Win32.SaveFileDialog();
                    outputDlg.Title = "Select AASX file repository to be saved";
                    outputDlg.FileName = "new-aasx-repo.json";

                    if (fr.Filename.HasContent())
                    {
                        outputDlg.InitialDirectory = Path.GetDirectoryName(fr.Filename);
                        outputDlg.FileName = Path.GetFileName(fr.Filename);
                    }

                    outputDlg.DefaultExt = "*.json";
                    outputDlg.Filter = "AASX repository files (*.json)|*.json|All files (*.*)|*.*";

                    if (Options.Curr.UseFlyovers) _flyout.StartFlyover(new EmptyFlyout());
                    var res = outputDlg.ShowDialog();
                    if (Options.Curr.UseFlyovers) _flyout.CloseFlyover();

                    if (res != true)
                        return;

                    // OK!
                    var fn = outputDlg.FileName;
                    try
                    {
                        Log.Singleton.Info($"Saving AASX file repository to {fn} ..");
                        fr.SaveAs(fn);
                    }
                    catch (Exception ex)
                    {
                        Log.Singleton.Error(ex, $"When saving AASX file repository to {fn}");
                    }
                }

                if (cmd == "filerepoquery")
                {
                    // dialogue
                    var uc = new SelectFromRepositoryFlyout();
                    uc.Margin = new Thickness(10);
                    if (uc.LoadAasxRepoFile(items: fr.EnumerateItems()))
                    {
                        uc.ControlClosed += () =>
                        {
                            var fi = uc.ResultItem;
                            var fn = fi?.Filename;
                            if (fn != null)
                            {
                                // start animation
                                fr.StartAnimation(fi,
                                    AasxFileRepository.FileItem.VisualStateEnum.ReadFrom);

                                try
                                {
                                    // load
                                    AasxPackageExplorer.Log.Singleton.Info("Switching to AASX repository file {0} ..", fn);
                                    FileDoubleClick?.Invoke(fr, fi);
                                }
                                catch (Exception ex)
                                {
                                    AasxPackageExplorer.Log.Singleton.Error(
                                        ex, $"When switching to AASX repository file {fn}.");
                                }
                            }
                        };
                        _flyout.StartFlyover(uc);
                    }
                }

                if (cmd == "filerepomakerelative")
                {
                    // make sure
                    if (MessageBoxResult.OK != _flyout.MessageBoxFlyoutShow(
                            "Make filename relative to the locaton of the file repository? " +
                            "This enables re-locating the repository.",
                            "AASX File Repository",
                            MessageBoxButton.OKCancel, MessageBoxImage.Hand))
                        return;


                    // execute (is data binded)
                    try
                    {
                        AasxPackageExplorer.Log.Singleton.Info("Make AASX file names relative to {0}", Path.GetFullPath(
                            Path.GetDirectoryName("" + fr.Filename)));
                        fr.MakeFilenamesRelative();
                    }
                    catch (Exception ex)
                    {
                        AasxPackageExplorer.Log.Singleton.Error(
                            ex, $"When making AASX file names in repository relative.");
                    }
                }

                if (cmd == "filerepoprint")
                {
                    // try print
                    try
                    {
                        AasxPrintFunctions.PrintRepositoryCodeSheet(
                            repoDirect: fr, title: "AASX file repository");
                    }
                    catch (Exception ex)
                    {
                        Log.Singleton.Error(ex, "When printing, an error occurred");
                    }
                }

                if (cmd == "filerepoaddcurrent")
                {
                    // check
                    var veAas = _manageVisuElems?.GetSelectedItem() as VisualElementAdminShell;

                    var veEnv = veAas.FindFirstParent((ve) => 
                    (ve is VisualElementEnvironmentItem vev 
                    && vev.theItemType == VisualElementEnvironmentItem.ItemType.Package), includeThis: false)
                        as VisualElementEnvironmentItem;

                    if (veAas == null || veAas.theAas == null || veAas.theEnv == null || veAas.thePackage == null
                        || veEnv == null || !veEnv.thePackageSourceFn.HasContent())
                    {
                        _flyout.MessageBoxFlyoutShow(
                            "No valid AAS selected. The application needs to be in edit mode. " +
                            "Aborting.", "AASX File repository",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    // add
                    fr.AddByAas(veAas.theEnv, veAas.theAas, "" + veEnv.thePackageSourceFn);
                }

                if (cmd == "filerepomultiadd")
                {
                    // get the input files
                    var inputDlg = new Microsoft.Win32.OpenFileDialog();
                    inputDlg.Title = "Multi-select AASX package files to be in repository";
                    inputDlg.Filter = "AASX package files (*.aasx)|*.aasx|AAS XML file (*.xml)|*.xml|All files (*.*)|*.*";
                    inputDlg.Multiselect = true;

                    _flyout.StartFlyover(new EmptyFlyout());
                    var res = inputDlg.ShowDialog();
                    _flyout.CloseFlyover();

                    if (res != true || inputDlg.FileNames.Length < 1)
                        return;

                    // loop
                    foreach (var fn in inputDlg.FileNames)
                        fr.AddByAasxFn(fn);
                }

                if (cmd == "filerepoaddfromserver")
                {
                    // read server address
                    var uc = new TextBoxFlyout("REST endpoint (without \"/server/listaas\"):", MessageBoxImage.Question);
                    uc.Text = "http://localhost:51310";
                    _flyout.StartFlyoverModal(uc);
                    if (!uc.Result)
                        return;

                    // execute
                    try
                    {
                        var conn = new PackageConnectorHttpRest(null, new Uri(uc.Text));

                        var task = Task.Run(() => conn.GenerateRepositoryFromEndpointAsync());
                        var items = task.Result;
                        if (items == null || items.Count < 1)
                        {
                            Log.Singleton.Error($"When adding file repo items from REST server {uc.Text}," +
                                $"the function returned NO items!");
                        }

                        // loop
                        foreach (var fi in items)
                            fr.Add(fi);
                    }
                    catch (Exception ex)
                    {
                        Log.Singleton.Error(ex, $"When adding file repo items from REST server {uc.Text}, " +
                            $"an error occurred");
                    }
                }

            }
        }

        //
        // Mechanics (of the control)
        //

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            // DIY -> this catches early the scroll events, before they are consumed by the individual
            // ListView of the child repo controls
            ScrollViewerRepoList.ScrollToVerticalOffset(ScrollViewerRepoList.VerticalOffset - e.Delta);
        }

        private void AasxFileRepoControl_FileDoubleClick(AasxFileRepository fr, AasxFileRepository.FileItem fi)
        {
            FileDoubleClick?.Invoke(fr, fi);
        }

        private void AasxFileRepoControl_ButtonClick(
            AasxFileRepository fr, AasxFileRepoControl.CustomButton btn,
            Button sender)
        {
            if (btn == AasxFileRepoControl.CustomButton.Context)
            {
                var cm = DynamicContextMenu.CreateNew(
                    new DynamicContextItem("FileRepoClose", "\u274c", "Close"),
                    new DynamicContextItem("item-up", "\u25b2", "Move Up"),
                    new DynamicContextItem("item-down", "\u25bc", "Move Down"),
                    new DynamicContextItem("", new Separator()),
                    new DynamicContextItem("FileRepoSaveAs", "\U0001f4be", "Save as .."),
                    // new DynamicContextItem("FileRepoQuery", "\u2753", "Query .."),
                    new DynamicContextItem("", new Separator()),
                    new DynamicContextItem("FileRepoMakeRelative", "\u2699", "Make AASX filenames relative .."),
                    new DynamicContextItem("FileRepoAddCurrent", "\u2699", "Add current AAS"),
                    new DynamicContextItem("FileRepoMultiAdd", "\u2699", "Add multiple AASX files .."),
                    new DynamicContextItem("FileRepoAddFromServer", "\u2699", "Add from REST server .."),
                    new DynamicContextItem("FileRepoPrint", "\u2699", "Print 2D code sheet ..")
                    );

                cm.Start(sender, (tag) =>
                {
                    CommandBinding_FileRepoAll(fr, tag);
                });
            }

            if (btn == AasxFileRepoControl.CustomButton.Query)
            {
                CommandBinding_FileRepoAll(fr, "FileRepoQuery");
            }
        }

        private void AasxFileRepoControl_FileDrop(AasxFileRepository fr, string[] files)
        {
            FileDrop?.Invoke(fr, files);
        }
    }
}