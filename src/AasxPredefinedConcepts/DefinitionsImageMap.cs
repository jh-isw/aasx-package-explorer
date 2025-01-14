/*
Copyright (c) 2018-2021 Festo AG & Co. KG <https://www.festo.com/net/de_de/Forms/web/contact_international>
Author: Michael Hoffmeister

This source code is licensed under the Apache License 2.0 (see LICENSE.txt).

This source code may use other Open Source software components (see LICENSE.txt).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminShellNS;

namespace AasxPredefinedConcepts
{
    /// <summary>
    /// Definitions for ImageMap plugin. Somehow preliminary, to be replaced by "full" JSON definitions
    /// </summary>
    public class ImageMap : AasxDefinitionBase
    {
        public static ImageMap Static = new ImageMap();

        public AdminShell.SemanticId
            SEM_ImageMapSubmodel;

        public AdminShell.ConceptDescription
            CD_ImageFile,
            CD_EntityOfImageMap,
            CD_RegionRect,
            CD_RegionCircle,
            CD_RegionPolygon,
            CD_NavigateTo,
            CD_VisualElement,
            CD_TextDisplay,
            CD_Foreground,
            CD_Background;

        public ImageMap()
        {
            // info
            this.DomainInfo = "Plugin ImageMap";

            // Referable
            SEM_ImageMapSubmodel = new AdminShell.SemanticId(
                AdminShell.Key.CreateNew(
                    type: "Submodel",
                    local: false,
                    idType: "IRI",
                    value: "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/Submodel/1/0"));

            CD_ImageFile = CreateSparseConceptDescription("en", "IRI",
                "ImageFile",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/ImageFile/1/0",
                @"File element with the image to be displayed.");

            CD_EntityOfImageMap = CreateSparseConceptDescription("en", "IRI",
                "EntityOfImageMap",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/EntityOfImageMap/1/0",
                @"States, that the Entity is part of an image map definition.");

            CD_RegionRect = CreateSparseConceptDescription("en", "IRI",
                "RegionRect",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/RegionRect/1/0",
                @"Definition of a rectangular region in JSON format [ x0, y0, x1, y1 ].");

            CD_RegionCircle = CreateSparseConceptDescription("en", "IRI",
                "RegionCircle",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/RegionCircle/1/0",
                @"Definition of a circular region in JSON format [ x0, y0, radius ].");

            CD_RegionPolygon = CreateSparseConceptDescription("en", "IRI",
                "RegionPolygon",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/RegionPolygon/1/0",
                @"Definition of a polygon region in JSON format [ x0, y0, x1, y1, .. ].");

            CD_NavigateTo = CreateSparseConceptDescription("en", "IRI",
                "NavigateTo",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/NavigateTo/1/0",
                @"If ReferenceElement subordinate to Entity, overrules Entity AssetId and navigates to value " +
                "reference .");

            CD_VisualElement = CreateSparseConceptDescription("en", "IRI",
                "VisualElement",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/VisualElement/1/0",
                @"Collection, wich represents a visual element on the image map.");

            CD_TextDisplay = CreateSparseConceptDescription("en", "IRI",
                "TextDisplay",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/TextDisplay/1/0",
                @"Property or ReferenceElement evaluating to value of text display.");

            CD_Foreground = CreateSparseConceptDescription("en", "IRI",
                "Foreground",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/Foreground/1/0",
                @"Property or ReferenceElement evaluating to value of foreground color in #argb format.");

            CD_Background = CreateSparseConceptDescription("en", "IRI",
                "Background",
                "http://admin-shell.io/aasx-package-explorer/plugins/ImageMap/Background/1/0",
                @"Property or ReferenceElement evaluating to value of background color in #argb format.");

            // reflect
            AddEntriesByReflection(this.GetType(), useAttributes: false, useFieldNames: true);
        }
    }
}
