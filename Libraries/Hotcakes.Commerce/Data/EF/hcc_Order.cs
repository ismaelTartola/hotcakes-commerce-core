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
    
    public partial class hcc_Order
    {
        public hcc_Order()
        {
            this.hcc_LineItem = new HashSet<hcc_LineItem>();
            this.hcc_OrderCoupon = new HashSet<hcc_OrderCoupon>();
            this.hcc_OrderNote = new HashSet<hcc_OrderNote>();
            this.hcc_OrderTransactions = new HashSet<hcc_OrderTransactions>();
            this.hcc_OrderPackage = new HashSet<hcc_OrderPackage>();
            this.hcc_RMA = new HashSet<hcc_RMA>();
        }
    
        public int Id { get; set; }
        public System.Guid bvin { get; set; }
        public Nullable<long> AffiliateId { get; set; }
        public string BillingAddress { get; set; }
        public string CustomProperties { get; set; }
        public decimal FraudScore { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal HandlingTotal { get; set; }
        public string Instructions { get; set; }
        public int IsPlaced { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public decimal OrderDiscounts { get; set; }
        public string OrderDiscountDetails { get; set; }
        public string OrderNumber { get; set; }
        public int PaymentStatus { get; set; }
        public string ShippingAddress { get; set; }
        public decimal ShippingDiscounts { get; set; }
        public string ShippingMethodId { get; set; }
        public string ShippingMethodDisplayName { get; set; }
        public string ShippingProviderId { get; set; }
        public string ShippingProviderServiceCode { get; set; }
        public int ShippingStatus { get; set; }
        public decimal ShippingTotal { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public System.DateTime TimeOfOrder { get; set; }
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public string StatusCode { get; set; }
        public string StatusName { get; set; }
        public string ThirdPartyOrderId { get; set; }
        public long StoreId { get; set; }
        public string ShippingDiscountDetails { get; set; }
        public decimal ItemsTax { get; set; }
        public decimal ShippingTax { get; set; }
        public decimal ShippingTaxRate { get; set; }
        public decimal AdjustedShippingTotal { get; set; }
        public int UserDeviceType { get; set; }
        public bool IsAbandonedEmailSent { get; set; }
        public bool IsRecurring { get; set; }
        public string UsedCulture { get; set; }
    
        public virtual ICollection<hcc_LineItem> hcc_LineItem { get; set; }
        public virtual ICollection<hcc_OrderCoupon> hcc_OrderCoupon { get; set; }
        public virtual ICollection<hcc_OrderNote> hcc_OrderNote { get; set; }
        public virtual ICollection<hcc_OrderTransactions> hcc_OrderTransactions { get; set; }
        public virtual ICollection<hcc_OrderPackage> hcc_OrderPackage { get; set; }
        public virtual ICollection<hcc_RMA> hcc_RMA { get; set; }
    }
}
