//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BhavnasERP.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblFranchiseInvoiceDetail
    {
        public int Id { get; set; }
        public int FranchiseId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    }
}
