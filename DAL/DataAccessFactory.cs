using DAL.Interface;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static ProjectEntities1 db;

        static DataAccessFactory()
        {
            db = new ProjectEntities1();

        }

        public static IRepo<User, int> UserDataAccess()
        {

            return new UserRepo(db);
        }
        public static IRepo<HotelInfo, int> HotelDataAccess()
        {
            return new HotelInfoRepo(db);
        }
        public static IRepo<Employee, int> EmployeeDataAccess()
        {
            return new EmployeeRepo(db);
        }
        public static IRepo<Booking, int> BookingDataAccess()
        {
            return new BookingRepo(db);
        }
        public static iAuth AuthDataAccess()
        {
            return new AuthRepo(db);
        }
    }
}
