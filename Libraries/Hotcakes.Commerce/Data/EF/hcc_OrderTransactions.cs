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
    
    public partial class hcc_OrderTransactions
    {
        public System.Guid Id { get; set; }
        public long StoreId { get; set; }
        public System.Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int Action { get; set; }
        public decimal Amount { get; set; }
        public string CreditCard { get; set; }
        public bool Success { get; set; }
        public bool Voided { get; set; }
        public string RefNum1 { get; set; }
        public string RefNum2 { get; set; }
        public string LinkedToTransaction { get; set; }
        public string Messages { get; set; }
        public string CheckNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string CompanyAccountNumber { get; set; }
        public string AdditionalSettings { get; set; }
        public string GiftCard { get; set; }
        public string MethodId { get; set; }
        public Nullable<long> LineItemId { get; set; }
    
        public virtual hcc_Stores hcc_Stores { get; set; }
        public virtual hcc_Order hcc_Order { get; set; }
    }
}
