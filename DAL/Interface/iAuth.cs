using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
     public interface iAuth
    {
        Token Authenticate(Admin admin);
        bool IsAuthenticated(string tok);
        bool Logout(string token);
    }
}
