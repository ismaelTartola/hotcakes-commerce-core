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
    
    public partial class hcc_ProductRelationship
    {
        public long Id { get; set; }
        public System.Guid ProductId { get; set; }
        public System.Guid RelatedProductId { get; set; }
        public int SortOrder { get; set; }
        public string MarketingDescription { get; set; }
        public long StoreId { get; set; }
        public bool IsSubstitute { get; set; }
    
        public virtual hcc_Product hcc_Product { get; set; }
    }
}
