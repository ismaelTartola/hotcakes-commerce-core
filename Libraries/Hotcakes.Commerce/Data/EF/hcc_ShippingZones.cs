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
    
    public partial class hcc_ShippingZones
    {
        public long Id { get; set; }
        public long StoreId { get; set; }
        public string Name { get; set; }
        public string Areas { get; set; }
    
        public virtual hcc_Stores hcc_Stores { get; set; }
    }
}
