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
     public class UserService
    {
        public static List<UserModel> GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>())).Map<List<UserModel>>(DataAccessFactory.UserDataAccess().GetAll());
            return data;
        }

        /* public static List<string> GetNames()
         {
             var data = (from e in DataAccessFactory.UserDataAccess().GetAll() select e.UserName).ToList();
             return data;
         }*/
        public static bool Delete(int id)
        {
            try
            {
                DataAccessFactory.UserDataAccess().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Edit(UserModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<UserModel, User>())).Map<User>(e);

            try
            {
                DataAccessFactory.UserDataAccess().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(UserModel e)

        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<UserModel, User>())).Map<User>(e);

            try
            {
                DataAccessFactory.UserDataAccess().Add(data);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static UserModel Get(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>())).Map<UserModel>(DataAccessFactory.UserDataAccess().Get(id));
            return data;
        }
    }
}
