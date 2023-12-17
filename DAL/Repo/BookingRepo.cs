using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
     public class BookingRepo:IRepo<Booking,int>
    {
        ProjectEntities1 db;

        public BookingRepo(ProjectEntities1 db)
        {

            this.db = db;

        }

        public void Add(Booking e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Booking e)
        {
            throw new NotImplementedException();
        }

        public Booking Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAll()
        {
            return db.Bookings.ToList();
        }
    }
}
