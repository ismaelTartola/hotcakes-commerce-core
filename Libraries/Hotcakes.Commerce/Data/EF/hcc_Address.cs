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
    
    public partial class hcc_Address
    {
        public int Id { get; set; }
        public string bvin { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string RegionBvin { get; set; }
        public string RegionName { get; set; }
        public string PostalCode { get; set; }
        public string CountryBvin { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string WebSiteUrl { get; set; }
        public string UserBvin { get; set; }
        public long StoreId { get; set; }
        public int AddressType { get; set; }
    }
}
