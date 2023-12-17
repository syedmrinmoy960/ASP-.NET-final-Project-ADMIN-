using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
     public class EmployeeService
    {
        public static List<EmployeeModel> GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeModel>())).Map<List<EmployeeModel>>(DataAccessFactory.EmployeeDataAccess().GetAll());
            return data;
        }

        public static List<string> GetNames()
        {
            var data = (from e in DataAccessFactory.EmployeeDataAccess().GetAll() select e.EmpName).ToList();
            return data;
        }
        public static bool Delete(int id)
        {
            try
            {
                DataAccessFactory.EmployeeDataAccess().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Edit(EmployeeModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EmployeeModel, Employee>())).Map<Employee>(e);

            try
            {
                DataAccessFactory.EmployeeDataAccess().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(EmployeeModel e)

        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EmployeeModel, Employee>())).Map<Employee>(e);

            try
            {
                DataAccessFactory.EmployeeDataAccess().Add(data);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static EmployeeModel Get(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeModel>())).Map<EmployeeModel>(DataAccessFactory.EmployeeDataAccess().Get(id));
            return data;
        }
    }
}
