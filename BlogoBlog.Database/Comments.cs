//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogoBlog.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int Id { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public System.DateTime Inserted { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
