using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
     public class AuthRepo:iAuth
    {
        ProjectEntities1 db;
        public AuthRepo(ProjectEntities1 db)
        {
            this.db = db;
        }
        public Token Authenticate(Admin admin)
        {
            Token t = null;
            var u = db.Admins.FirstOrDefault(e => e.AdminUserName == admin.AdminUserName && e.AdminPassword == admin.AdminPassword);
            if (u != null)
            {
                var g = Guid.NewGuid().ToString();
                t = new Token()
                {
                    AdminId = u.AdminId,
                    accessToken = g,
                    createdAt = DateTime.Now
                };
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;



        }



        public bool IsAuthenticated(string tok)
        {
            /* var pc = db.Tokens.ToList();
             foreach(var ch in pc)
             {
                 var ph = ch.accessToken;
                 if (ph == tok)
                 {
                     return true;
                 }
             }*/
            var ac_token = db.Tokens.FirstOrDefault(e => e.accessToken.Equals(tok) && e.expireAt == null);
            if (ac_token != null)
            {
                return true;
            }
            return false;
        }



        public bool Logout(string tok)
        {
            var t = db.Tokens.FirstOrDefault(e => e.accessToken.Equals(tok));
            if (t != null)
            {
                t.expireAt = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
