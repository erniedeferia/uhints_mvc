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
    
    public partial class UserLogin
    {
        public int Id { get; set; }
        public long user_id { get; set; }
        public int FailedAttemptCount { get; set; }
        public Nullable<System.DateTime> LockedEndDtUTC { get; set; }
    
        public virtual tbl_Users tbl_Users { get; set; }
    }
}
