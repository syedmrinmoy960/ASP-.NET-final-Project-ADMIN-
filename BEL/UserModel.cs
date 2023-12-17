using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
     public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserNid { get; set; }
        public string UserContract { get; set; }
        public Nullable<System.DateTime> UserDOB { get; set; }
        public int HotelId { get; set; }
    }
}
