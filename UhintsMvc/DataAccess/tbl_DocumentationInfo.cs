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
    
    public partial class tbl_DocumentationInfo
    {
        public int DocumentationInfo_Id { get; set; }
        public int Customer_Id { get; set; }
        public string DocumentType { get; set; }
        public string DocumentStatus { get; set; }
        public string ReceivedBy { get; set; }
        public Nullable<int> DocumentNo { get; set; }
    }
}
