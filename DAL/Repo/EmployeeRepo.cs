using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
     public class EmployeeRepo:IRepo<Employee,int>
    {
        ProjectEntities1 db;

        public EmployeeRepo(ProjectEntities1 db)
        {

            this.db = db;

        }
        public void Add(Employee e)
        {
            db.Employees.Add(e);
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
            var d = db.Employees.FirstOrDefault(er => er.EmpId == id);
            db.Employees.Remove(d);
            db.SaveChanges();
        }



        public void Edit(Employee e)
        {

            var p = db.Employees.FirstOrDefault(en => en.EmpId == e.EmpId);
            db.Entry(p).CurrentValues.SetValues(e);
            db.SaveChanges();


        }
        public List<Employee> GetAll()
        {
            return db.Employees.ToList();

        }

        public Employee Get(int id)
        {
            return db.Employees.FirstOrDefault(en => en.EmpId == id);
        }
    }
}
