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
[System.Xml.Serialization.XmlRootAttribute("PricingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PricingReferenceType {
    
    private ItemLocationQuantityType originalItemLocationQuantityField;
    
    private PriceType[] alternativeConditionPriceField;
    
    /// <remarks/>
    public ItemLocationQuantityType OriginalItemLocationQuantity {
        get {
            return this.originalItemLocationQuantityField;
        }
        set {
            this.originalItemLocationQuantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice")]
    public PriceType[] AlternativeConditionPrice {
        get {
            return this.alternativeConditionPriceField;
        }
        set {
            this.alternativeConditionPriceField = value;
        }
    }
}