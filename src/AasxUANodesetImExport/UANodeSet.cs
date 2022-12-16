﻿/*
Copyright (c) 2018-2020 Festo AG & Co. KG <https://www.festo.com/net/de_de/Forms/web/contact_international>
Author: Michael Hoffmeister

Copyright (c) 2020 Phoenix Contact GmbH & Co. KG <opensource@phoenixcontact.com>
Author: Andreas Orzelski

Copyright (c) 2020 Fraunhofer IOSB-INA Lemgo, 
    eine rechtlich nicht selbständige Einrichtung der Fraunhofer-Gesellschaft
    zur Förderung der angewandten Forschung e.V. <jan.nicolas.weskamp@iosb-ina.fraunhofer.de>
Author: Jan Nicolas Weskamp

This source code is licensed under the Apache License 2.0 (see LICENSE.txt).

This source code may use other Open Source software components (see LICENSE.txt).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO (Michael Hoffmeister, 2020-08-01): Fraunhofer IOSB: Check ReSharper to be OK

// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantCast

namespace AasxUANodesetImExport
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(
        AnonymousType = true, Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(
        Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd", IsNullable = false)]
    public partial class UANodeSet
    {

        private string[] namespaceUrisField;

        private string[] serverUrisField;

        private ModelTableEntry[] modelsField;

        private NodeIdAlias[] aliasesField;

        private System.Xml.XmlElement[] extensionsField;

        private UANode[] itemsField;

        private System.DateTime lastModifiedField;

        private bool lastModifiedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Uri", IsNullable = false)]
        public string[] NamespaceUris
        {
            get
            {
                return this.namespaceUrisField;
            }
            set
            {
                this.namespaceUrisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Uri", IsNullable = false)]
        public string[] ServerUris
        {
            get
            {
                return this.serverUrisField;
            }
            set
            {
                this.serverUrisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Model", IsNullable = false)]
        public ModelTableEntry[] Models
        {
            get
            {
                return this.modelsField;
            }
            set
            {
                this.modelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Alias", IsNullable = false)]
        public NodeIdAlias[] Aliases
        {
            get
            {
                return this.aliasesField;
            }
            set
            {
                this.aliasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Extension", IsNullable = false)]
        public System.Xml.XmlElement[] Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UADataType", typeof(UADataType))]
        [System.Xml.Serialization.XmlElementAttribute("UAMethod", typeof(UAMethod))]
        [System.Xml.Serialization.XmlElementAttribute("UAObject", typeof(UAObject))]
        [System.Xml.Serialization.XmlElementAttribute("UAObjectType", typeof(UAObjectType))]
        [System.Xml.Serialization.XmlElementAttribute("UAReferenceType", typeof(UAReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("UAVariable", typeof(UAVariable))]
        [System.Xml.Serialization.XmlElementAttribute("UAVariableType", typeof(UAVariableType))]
        [System.Xml.Serialization.XmlElementAttribute("UAView", typeof(UAView))]
        public UANode[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModified
        {
            get
            {
                return this.lastModifiedField;
            }
            set
            {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifiedSpecified
        {
            get
            {
                return this.lastModifiedFieldSpecified;
            }
            set
            {
                this.lastModifiedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class ModelTableEntry
    {

        private RolePermission[] rolePermissionsField;

        private ModelTableEntry[] requiredModelField;

        private string modelUriField;

        private string versionField;

        private System.DateTime publicationDateField;

        private bool publicationDateFieldSpecified;

        private byte accessRestrictionsField;

        public ModelTableEntry()
        {
            this.accessRestrictionsField = ((byte)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public RolePermission[] RolePermissions
        {
            get
            {
                return this.rolePermissionsField;
            }
            set
            {
                this.rolePermissionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredModel")]
        public ModelTableEntry[] RequiredModel
        {
            get
            {
                return this.requiredModelField;
            }
            set
            {
                this.requiredModelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ModelUri
        {
            get
            {
                return this.modelUriField;
            }
            set
            {
                this.modelUriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime PublicationDate
        {
            get
            {
                return this.publicationDateField;
            }
            set
            {
                this.publicationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PublicationDateSpecified
        {
            get
            {
                return this.publicationDateFieldSpecified;
            }
            set
            {
                this.publicationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte AccessRestrictions
        {
            get
            {
                return this.accessRestrictionsField;
            }
            set
            {
                this.accessRestrictionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class RolePermission
    {

        private uint permissionsField;

        private string valueField;

        public RolePermission()
        {
            this.permissionsField = ((uint)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Permissions
        {
            get
            {
                return this.permissionsField;
            }
            set
            {
                this.permissionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class NodeSetStatus
    {

        private uint codeField;

        private string valueField;

        public NodeSetStatus()
        {
            this.codeField = ((uint)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class NodeToDelete
    {

        private bool deleteReverseReferencesField;

        private string valueField;

        public NodeToDelete()
        {
            this.deleteReverseReferencesField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool DeleteReverseReferences
        {
            get
            {
                return this.deleteReverseReferencesField;
            }
            set
            {
                this.deleteReverseReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class ReferenceChange
    {

        private string sourceField;

        private string referenceTypeField;

        private bool isForwardField;

        private string valueField;

        public ReferenceChange()
        {
            this.isForwardField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsForward
        {
            get
            {
                return this.isForwardField;
            }
            set
            {
                this.isForwardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class DataTypeField
    {

        private LocalizedText[] displayNameField;

        private LocalizedText[] descriptionField;

        private string documentationField;

        private string nameField;

        private string symbolicNameField;

        private string dataTypeField;

        private int valueRankField;

        private string arrayDimensionsField;

        private uint maxStringLengthField;

        private int valueField;

        private bool isOptionalField;

        public DataTypeField()
        {
            this.dataTypeField = "i=24";
            this.valueRankField = -1;
            this.arrayDimensionsField = "";
            this.maxStringLengthField = ((uint)(0));
            this.valueField = -1;
            this.isOptionalField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DisplayName")]
        public LocalizedText[] DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public LocalizedText[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string Documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SymbolicName
        {
            get
            {
                return this.symbolicNameField;
            }
            set
            {
                this.symbolicNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("i=24")]
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int ValueRank
        {
            get
            {
                return this.valueRankField;
            }
            set
            {
                this.valueRankField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ArrayDimensions
        {
            get
            {
                return this.arrayDimensionsField;
            }
            set
            {
                this.arrayDimensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint MaxStringLength
        {
            get
            {
                return this.maxStringLengthField;
            }
            set
            {
                this.maxStringLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsOptional
        {
            get
            {
                return this.isOptionalField;
            }
            set
            {
                this.isOptionalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class LocalizedText
    {

        private string localeField;

        private string valueField;

        public LocalizedText()
        {
            this.localeField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Locale
        {
            get
            {
                return this.localeField;
            }
            set
            {
                this.localeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class DataTypeDefinition
    {

        private DataTypeField[] fieldField;

        private string nameField;

        private string symbolicNameField;

        private bool isUnionField;

        private bool isOptionSetField;

        private string baseTypeField;

        public DataTypeDefinition()
        {
            this.symbolicNameField = "";
            this.isUnionField = false;
            this.isOptionSetField = false;
            this.baseTypeField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Field")]
        public DataTypeField[] Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SymbolicName
        {
            get
            {
                return this.symbolicNameField;
            }
            set
            {
                this.symbolicNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsUnion
        {
            get
            {
                return this.isUnionField;
            }
            set
            {
                this.isUnionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsOptionSet
        {
            get
            {
                return this.isOptionSetField;
            }
            set
            {
                this.isOptionSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BaseType
        {
            get
            {
                return this.baseTypeField;
            }
            set
            {
                this.baseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAMethodArgument
    {

        private string nameField;

        private LocalizedText[] descriptionField;

        private string documentationField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public LocalizedText[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string Documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class StructureTranslationType
    {

        private LocalizedText[] textField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public LocalizedText[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class TranslationType
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Field", typeof(StructureTranslationType))]
        [System.Xml.Serialization.XmlElementAttribute("Text", typeof(LocalizedText))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class Reference
    {

        private string referenceTypeField;

        private bool isForwardField;

        private string valueField;

        public Reference()
        {
            this.isForwardField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsForward
        {
            get
            {
                return this.isForwardField;
            }
            set
            {
                this.isForwardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UADataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariableType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAInstance))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAView))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAMethod))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObject))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UANode
    {

        private LocalizedText[] displayNameField;

        private LocalizedText[] descriptionField;

        private string[] categoryField;

        private string documentationField;

        private Reference[] referencesField;

        private RolePermission[] rolePermissionsField;

        private System.Xml.XmlElement[] extensionsField;

        private string nodeIdField;

        private string browseNameField;

        private uint writeMaskField;

        private uint userWriteMaskField;

        private byte accessRestrictionsField;

        private string symbolicNameField;

        public UANode()
        {
            this.writeMaskField = ((uint)(0));
            this.userWriteMaskField = ((uint)(0));
            this.accessRestrictionsField = ((byte)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DisplayName")]
        public LocalizedText[] DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public LocalizedText[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public string[] Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public string Documentation
        {
            get
            {
                return this.documentationField;
            }
            set
            {
                this.documentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public Reference[] References
        {
            get
            {
                return this.referencesField;
            }
            set
            {
                this.referencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public RolePermission[] RolePermissions
        {
            get
            {
                return this.rolePermissionsField;
            }
            set
            {
                this.rolePermissionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Extension", IsNullable = false)]
        public System.Xml.XmlElement[] Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NodeId
        {
            get
            {
                return this.nodeIdField;
            }
            set
            {
                this.nodeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrowseName
        {
            get
            {
                return this.browseNameField;
            }
            set
            {
                this.browseNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint WriteMask
        {
            get
            {
                return this.writeMaskField;
            }
            set
            {
                this.writeMaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "0")]
        public uint UserWriteMask
        {
            get
            {
                return this.userWriteMaskField;
            }
            set
            {
                this.userWriteMaskField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte AccessRestrictions
        {
            get
            {
                return this.accessRestrictionsField;
            }
            set
            {
                this.accessRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SymbolicName
        {
            get
            {
                return this.symbolicNameField;
            }
            set
            {
                this.symbolicNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UADataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariableType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObjectType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAType : UANode
    {

        private bool isAbstractField;

        public UAType()
        {
            this.isAbstractField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsAbstract
        {
            get
            {
                return this.isAbstractField;
            }
            set
            {
                this.isAbstractField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAReferenceType : UAType
    {

        private LocalizedText[] inverseNameField;

        private bool symmetricField;

        public UAReferenceType()
        {
            this.symmetricField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InverseName")]
        public LocalizedText[] InverseName
        {
            get
            {
                return this.inverseNameField;
            }
            set
            {
                this.inverseNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Symmetric
        {
            get
            {
                return this.symmetricField;
            }
            set
            {
                this.symmetricField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UADataType : UAType
    {

        private DataTypeDefinition definitionField;

        /// <remarks/>
        public DataTypeDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAVariableType : UAType
    {

        private System.Xml.XmlElement valueField;

        private string dataTypeField;

        private int valueRankField;

        private string arrayDimensionsField;

        public UAVariableType()
        {
            this.dataTypeField = "i=24";
            this.valueRankField = -1;
            this.arrayDimensionsField = "";
        }

        /// <remarks/>
        public System.Xml.XmlElement Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("i=24")]
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int ValueRank
        {
            get
            {
                return this.valueRankField;
            }
            set
            {
                this.valueRankField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ArrayDimensions
        {
            get
            {
                return this.arrayDimensionsField;
            }
            set
            {
                this.arrayDimensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAObjectType : UAType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAView))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAMethod))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAVariable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UAObject))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAInstance : UANode
    {

        private string parentNodeIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParentNodeId
        {
            get
            {
                return this.parentNodeIdField;
            }
            set
            {
                this.parentNodeIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAView : UAInstance
    {

        private bool containsNoLoopsField;

        private byte eventNotifierField;

        public UAView()
        {
            this.containsNoLoopsField = false;
            this.eventNotifierField = ((byte)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ContainsNoLoops
        {
            get
            {
                return this.containsNoLoopsField;
            }
            set
            {
                this.containsNoLoopsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte EventNotifier
        {
            get
            {
                return this.eventNotifierField;
            }
            set
            {
                this.eventNotifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAMethod : UAInstance
    {

        private UAMethodArgument[] argumentDescriptionField;

        private bool executableField;

        private bool userExecutableField;

        private string methodDeclarationIdField;

        public UAMethod()
        {
            this.executableField = true;
            this.userExecutableField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArgumentDescription")]
        public UAMethodArgument[] ArgumentDescription
        {
            get
            {
                return this.argumentDescriptionField;
            }
            set
            {
                this.argumentDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Executable
        {
            get
            {
                return this.executableField;
            }
            set
            {
                this.executableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool UserExecutable
        {
            get
            {
                return this.userExecutableField;
            }
            set
            {
                this.userExecutableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MethodDeclarationId
        {
            get
            {
                return this.methodDeclarationIdField;
            }
            set
            {
                this.methodDeclarationIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAVariable : UAInstance
    {

        private System.Xml.XmlElement valueField;

        private TranslationType[] translationField;

        private string dataTypeField;

        private int valueRankField;

        private string arrayDimensionsField;

        private uint accessLevelField;

        private uint userAccessLevelField;

        private double minimumSamplingIntervalField;

        private bool historizingField;

        public UAVariable()
        {
            this.dataTypeField = "i=24";
            this.valueRankField = -1;
            this.arrayDimensionsField = "";
            this.accessLevelField = ((uint)(1));
            this.userAccessLevelField = ((uint)(1));
            this.minimumSamplingIntervalField = 0;
            this.historizingField = false;
        }

        /// <remarks/>
        public System.Xml.XmlElement Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Translation")]
        public TranslationType[] Translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("i=24")]
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int ValueRank
        {
            get
            {
                return this.valueRankField;
            }
            set
            {
                this.valueRankField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ArrayDimensions
        {
            get
            {
                return this.arrayDimensionsField;
            }
            set
            {
                this.arrayDimensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "1")]
        public uint AccessLevel
        {
            get
            {
                return this.accessLevelField;
            }
            set
            {
                this.accessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(uint), "1")]
        public uint UserAccessLevel
        {
            get
            {
                return this.userAccessLevelField;
            }
            set
            {
                this.userAccessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public double MinimumSamplingInterval
        {
            get
            {
                return this.minimumSamplingIntervalField;
            }
            set
            {
                this.minimumSamplingIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Historizing
        {
            get
            {
                return this.historizingField;
            }
            set
            {
                this.historizingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class UAObject : UAInstance
    {

        private byte eventNotifierField;

        public UAObject()
        {
            this.eventNotifierField = ((byte)(0));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(typeof(byte), "0")]
        public byte EventNotifier
        {
            get
            {
                return this.eventNotifierField;
            }
            set
            {
                this.eventNotifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    public partial class NodeIdAlias
    {

        private string aliasField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(
        AnonymousType = true, Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(
        Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd", IsNullable = false)]
    public partial class UANodeSetChanges
    {

        private string[] namespaceUrisField;

        private string[] serverUrisField;

        private NodeIdAlias[] aliasesField;

        private System.Xml.XmlElement[] extensionsField;

        private UANode[] nodesToAddField;

        private ReferenceChange[] referencesToAddField;

        private NodeToDelete[] nodesToDeleteField;

        private ReferenceChange[] referencesToDeleteField;

        private System.DateTime lastModifiedField;

        private bool lastModifiedFieldSpecified;

        private string transactionIdField;

        private bool acceptAllOrNothingField;

        public UANodeSetChanges()
        {
            this.acceptAllOrNothingField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Uri", IsNullable = false)]
        public string[] NamespaceUris
        {
            get
            {
                return this.namespaceUrisField;
            }
            set
            {
                this.namespaceUrisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Uri", IsNullable = false)]
        public string[] ServerUris
        {
            get
            {
                return this.serverUrisField;
            }
            set
            {
                this.serverUrisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Alias", IsNullable = false)]
        public NodeIdAlias[] Aliases
        {
            get
            {
                return this.aliasesField;
            }
            set
            {
                this.aliasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Extension", IsNullable = false)]
        public System.Xml.XmlElement[] Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UADataType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UAMethod), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UAObject), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UAObjectType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UAReferenceType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UAVariable), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UAVariableType), IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(UAView), IsNullable = false)]
        public UANode[] NodesToAdd
        {
            get
            {
                return this.nodesToAddField;
            }
            set
            {
                this.nodesToAddField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
        public ReferenceChange[] ReferencesToAdd
        {
            get
            {
                return this.referencesToAddField;
            }
            set
            {
                this.referencesToAddField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Node", IsNullable = false)]
        public NodeToDelete[] NodesToDelete
        {
            get
            {
                return this.nodesToDeleteField;
            }
            set
            {
                this.nodesToDeleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
        public ReferenceChange[] ReferencesToDelete
        {
            get
            {
                return this.referencesToDeleteField;
            }
            set
            {
                this.referencesToDeleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModified
        {
            get
            {
                return this.lastModifiedField;
            }
            set
            {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifiedSpecified
        {
            get
            {
                return this.lastModifiedFieldSpecified;
            }
            set
            {
                this.lastModifiedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionId
        {
            get
            {
                return this.transactionIdField;
            }
            set
            {
                this.transactionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AcceptAllOrNothing
        {
            get
            {
                return this.acceptAllOrNothingField;
            }
            set
            {
                this.acceptAllOrNothingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(
        AnonymousType = true, Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(
        Namespace = "http://opcfoundation.org/UA/2011/03/UANodeSet.xsd", IsNullable = false)]
    public partial class UANodeSetChangesStatus
    {

        private NodeSetStatus[] nodesToAddField;

        private NodeSetStatus[] referencesToAddField;

        private NodeSetStatus[] nodesToDeleteField;

        private NodeSetStatus[] referencesToDeleteField;

        private System.DateTime lastModifiedField;

        private bool lastModifiedFieldSpecified;

        private string transactionIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Status", IsNullable = false)]
        public NodeSetStatus[] NodesToAdd
        {
            get
            {
                return this.nodesToAddField;
            }
            set
            {
                this.nodesToAddField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Status", IsNullable = false)]
        public NodeSetStatus[] ReferencesToAdd
        {
            get
            {
                return this.referencesToAddField;
            }
            set
            {
                this.referencesToAddField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Status", IsNullable = false)]
        public NodeSetStatus[] NodesToDelete
        {
            get
            {
                return this.nodesToDeleteField;
            }
            set
            {
                this.nodesToDeleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Status", IsNullable = false)]
        public NodeSetStatus[] ReferencesToDelete
        {
            get
            {
                return this.referencesToDeleteField;
            }
            set
            {
                this.referencesToDeleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModified
        {
            get
            {
                return this.lastModifiedField;
            }
            set
            {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifiedSpecified
        {
            get
            {
                return this.lastModifiedFieldSpecified;
            }
            set
            {
                this.lastModifiedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransactionId
        {
            get
            {
                return this.transactionIdField;
            }
            set
            {
                this.transactionIdField = value;
            }
        }
    }
}