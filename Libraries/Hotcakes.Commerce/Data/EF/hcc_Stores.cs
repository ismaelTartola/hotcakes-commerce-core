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
    
    public partial class hcc_Stores
    {
        public hcc_Stores()
        {
            this.hcc_OrderTransactions = new HashSet<hcc_OrderTransactions>();
            this.hcc_ShippingZones = new HashSet<hcc_ShippingZones>();
            this.hcc_Taxes = new HashSet<hcc_Taxes>();
            this.hcc_TaxSchedules = new HashSet<hcc_TaxSchedules>();
            this.hcc_StoresXUsers = new HashSet<hcc_StoresXUsers>();
            this.hcc_StoreSettings = new HashSet<hcc_StoreSettings>();
        }
    
        public long Id { get; set; }
        public string StoreName { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CustomUrl { get; set; }
        public System.Guid StoreGuid { get; set; }
        public int LastOrderNumber { get; set; }
    
        public virtual ICollection<hcc_OrderTransactions> hcc_OrderTransactions { get; set; }
        public virtual ICollection<hcc_ShippingZones> hcc_ShippingZones { get; set; }
        public virtual ICollection<hcc_Taxes> hcc_Taxes { get; set; }
        public virtual ICollection<hcc_TaxSchedules> hcc_TaxSchedules { get; set; }
        public virtual ICollection<hcc_StoresXUsers> hcc_StoresXUsers { get; set; }
        public virtual ICollection<hcc_StoreSettings> hcc_StoreSettings { get; set; }
    }
}
