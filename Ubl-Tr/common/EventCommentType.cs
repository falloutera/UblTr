//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EventComment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EventCommentType {
    
    private CommentType commentField;
    
    private IssueDateType issueDateField;
    
    private IssueTimeType issueTimeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CommentType Comment {
        get {
            return this.commentField;
        }
        set {
            this.commentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate {
        get {
            return this.issueDateField;
        }
        set {
            this.issueDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime {
        get {
            return this.issueTimeField;
        }
        set {
            this.issueTimeField = value;
        }
    }
}