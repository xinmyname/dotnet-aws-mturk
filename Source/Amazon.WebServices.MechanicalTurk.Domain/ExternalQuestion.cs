﻿#region Copyright & license notice
/*
 * Copyright: Copyright (c) 2007 Amazon Technologies, Inc.
 * License:   Apache License, Version 2.0
 */
#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 
namespace Amazon.WebServices.MechanicalTurk.Domain{
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2006-07-14/Exter" +
        "nalQuestion.xsd", IsNullable=false)]
    public partial class ExternalQuestion {
        
        private string externalURLField;
        
        private string frameHeightField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string ExternalURL {
            get {
                return this.externalURLField;
            }
            set {
                this.externalURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string FrameHeight {
            get {
                return this.frameHeightField;
            }
            set {
                this.frameHeightField = value;
            }
        }
    }
}