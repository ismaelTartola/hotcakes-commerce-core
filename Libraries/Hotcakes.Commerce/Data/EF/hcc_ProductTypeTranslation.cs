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
    
    public partial class hcc_ProductTypeTranslation
    {
        public long ProductTypeTranslationId { get; set; }
        public System.Guid ProductTypeId { get; set; }
        public string Culture { get; set; }
        public string ProductTypeName { get; set; }
    
        public virtual hcc_ProductType hcc_ProductType { get; set; }
    }
}
