//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotcakes.Commerce.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_ProductProperty
    {
        public hcc_ProductProperty()
        {
            this.hcc_ProductPropertyChoice = new HashSet<hcc_ProductPropertyChoice>();
            this.hcc_ProductPropertyValue = new HashSet<hcc_ProductPropertyValue>();
            this.hcc_ProductPropertyTranslations = new HashSet<hcc_ProductPropertyTranslation>();
            this.hcc_ProductTypeXProductProperty = new HashSet<hcc_ProductTypeXProductProperty>();
        }
    
        public long Id { get; set; }
        public string PropertyName { get; set; }
        public int DisplayOnSite { get; set; }
        public int DisplayToDropShipper { get; set; }
        public int TypeCode { get; set; }
        public string DefaultValue { get; set; }
        public string CultureCode { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
        public bool DisplayOnSearch { get; set; }
        public bool IsLocalizable { get; set; }
    
        public virtual ICollection<hcc_ProductPropertyChoice> hcc_ProductPropertyChoice { get; set; }
        public virtual ICollection<hcc_ProductPropertyValue> hcc_ProductPropertyValue { get; set; }
        public virtual ICollection<hcc_ProductPropertyTranslation> hcc_ProductPropertyTranslations { get; set; }
        public virtual ICollection<hcc_ProductTypeXProductProperty> hcc_ProductTypeXProductProperty { get; set; }
    }
}
