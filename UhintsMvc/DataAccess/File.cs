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
    
    public partial class File
    {
        public int Id { get; set; }
        public string directoryFileId { get; set; }
        public string fileName { get; set; }
        public int folderId { get; set; }
        public long userId { get; set; }
        public int statusId { get; set; }
        public System.DateTime createdDate { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public string description { get; set; }
    
        public virtual FileStatu FileStatu { get; set; }
        public virtual Folder Folder { get; set; }
        public virtual tbl_Users tbl_Users { get; set; }
    }
}
