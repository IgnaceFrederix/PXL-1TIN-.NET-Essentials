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
    
    public partial class States
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public States()
        {
            this.Vendors = new HashSet<Vendors>();
        }
    
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public int FirstZipCode { get; set; }
        public int LastZipCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendors> Vendors { get; set; }
    }
}
