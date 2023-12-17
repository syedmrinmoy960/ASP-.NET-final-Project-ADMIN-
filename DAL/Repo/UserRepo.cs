using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
     public class UserRepo:IRepo<User,int>
    {
        ProjectEntities1 db;

        public UserRepo(ProjectEntities1 db)
        {

            this.db = db;

        }
        public void Add(User e)
        {
            db.Users.Add(e);
            db.SaveChanges();
        }

        /* public void Delete(int id)
         {
             var ch = db.HotelInfo.FirstOrDefault(e => e.HotelId == id);
             db.HotelInfo.Remove(ch);
             db.SaveChanges();
         }*/

        public void Delete(int id)
        {
            var d = db.Users.FirstOrDefault(er => er.UserId == id);
            db.Users.Remove(d);
            db.SaveChanges();
        }



        public void Edit(User e)
        {

            var p = db.Users.FirstOrDefault(en => en.UserId == e.UserId);
            db.Entry(p).CurrentValues.SetValues(e);
            db.SaveChanges();


        }
        public List<User> GetAll()
        {
            /*return db.HotelInfo.ToList();*/
            return db.Users.ToList();

        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(en => en.UserId == id);
        }
    }
}
