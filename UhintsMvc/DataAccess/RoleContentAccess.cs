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
    
    public partial class RoleContentAccess
    {
        public int RoleContentAccessId { get; set; }
        public int RoleId { get; set; }
        public int ContentId { get; set; }
    
        public virtual Content Content { get; set; }
        public virtual Role Role { get; set; }
    }
}
