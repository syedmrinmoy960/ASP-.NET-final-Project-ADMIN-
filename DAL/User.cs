//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserNid { get; set; }
        public string UserContract { get; set; }
        public Nullable<System.DateTime> UserDOB { get; set; }
        public int HotelId { get; set; }
    
        public virtual HotelInfo HotelInfo { get; set; }
    }
}
