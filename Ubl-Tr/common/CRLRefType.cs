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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
public partial class CRLRefType {
    
    private DigestAlgAndValueType digestAlgAndValueField;
    
    private CRLIdentifierType cRLIdentifierField;
    
    /// <remarks/>
    public DigestAlgAndValueType DigestAlgAndValue {
        get {
            return this.digestAlgAndValueField;
        }
        set {
            this.digestAlgAndValueField = value;
        }
    }
    
    /// <remarks/>
    public CRLIdentifierType CRLIdentifier {
        get {
            return this.cRLIdentifierField;
        }
        set {
            this.cRLIdentifierField = value;
        }
    }
}