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
    
    public partial class hcc_SearchObjectWord
    {
        public long SearchObjectId { get; set; }
        public long WordId { get; set; }
        public int Score { get; set; }
        public long SiteId { get; set; }
    
        public virtual hcc_SearchLexicon hcc_SearchLexicon { get; set; }
        public virtual hcc_SearchObject hcc_SearchObjects { get; set; }
    }
}
