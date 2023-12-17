using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class HotelInfoRepo:IRepo<HotelInfo,int>
    {
        ProjectEntities1 db;

        public HotelInfoRepo(ProjectEntities1 db)
        {

            this.db = db;

        }
        public void Add(HotelInfo e)
        {
            db.HotelInfoes.Add(e);
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
            var d = db.HotelInfoes.FirstOrDefault(er => er.HotelId == id);
            db.HotelInfoes.Remove(d);
            db.SaveChanges();
        }



        public void Edit(HotelInfo e)
        {

            var p = db.HotelInfoes.FirstOrDefault(en => en.HotelId == e.HotelId);
            db.Entry(p).CurrentValues.SetValues(e);
            db.SaveChanges();


        }
        public List<HotelInfo> GetAll()
        {
            /*return db.HotelInfo.ToList();*/
            return db.HotelInfoes.ToList();

        }

        public HotelInfo Get(int id)
        {
            return db.HotelInfoes.FirstOrDefault(en => en.HotelId == id);
        }
    }
}
