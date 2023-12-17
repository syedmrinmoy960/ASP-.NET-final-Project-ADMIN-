using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public  class TokenModel
    {
        public int id { get; set; }
        public Nullable<int> AdminId { get; set; }
        public string accessToken { get; set; }
        public System.DateTime createdAt { get; set; }
        public Nullable<System.DateTime> expireAt { get; set; }
    }
}
