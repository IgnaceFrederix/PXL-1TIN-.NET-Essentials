//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace week11
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceLineItems
    {
        public int InvoiceID { get; set; }
        public short InvoiceSequence { get; set; }
        public int AccountNo { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    
        public virtual GLAccounts GLAccounts { get; set; }
        public virtual Invoices Invoices { get; set; }
    }
}
