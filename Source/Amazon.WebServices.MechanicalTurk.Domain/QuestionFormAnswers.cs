﻿#region Copyright & license notice
/*
 * Copyright: Copyright (c) 2007 Amazon Technologies, Inc.
 * License:   Apache License, Version 2.0
 */
#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.832
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 
namespace Amazon.WebServices.MechanicalTurk.Domain {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd", IsNullable=false)]
    public partial class QuestionFormAnswers {
        
        private QuestionFormAnswersAnswer[] answerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Answer")]
        public QuestionFormAnswersAnswer[] Answer {
            get {
                return this.answerField;
            }
            set {
                this.answerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd")]
    public partial class QuestionFormAnswersAnswer {
        
        private string questionIdentifierField;
        
        private string[] itemsField;
        
        private AnswerItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        public string QuestionIdentifier {
            get {
                return this.questionIdentifierField;
            }
            set {
                this.questionIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreeText", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("OtherSelectionText", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SelectionIdentifier", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UploadedFileKey", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UploadedFileSizeInBytes", typeof(string), DataType="positiveInteger")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public AnswerItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks>
    /// Manually modified because ItemsChoiceType already existed in QuestionForm.xsd
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ItemsChoiceType", Namespace="http://mechanicalturk.amazonaws.com/AWSMechanicalTurkDataSchemas/2005-10-01/Quest" +
        "ionFormAnswers.xsd", IncludeInSchema=false)]
    public enum AnswerItemsChoiceType {
        
        /// <remarks/>
        FreeText,
        
        /// <remarks/>
        OtherSelectionText,
        
        /// <remarks/>
        SelectionIdentifier,
        
        /// <remarks/>
        UploadedFileKey,
        
        /// <remarks/>
        UploadedFileSizeInBytes,
    }
}
