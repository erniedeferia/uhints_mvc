//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UhintsMvc.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_States
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_States()
        {
            this.tbl_Customers = new HashSet<tbl_Customers>();
        }
    
        public int State_Id { get; set; }
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Customers> tbl_Customers { get; set; }
    }
}
