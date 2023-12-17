using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace BLL.Services
{
    public class HotelInfoService
    {
        public static List<HotelModel> GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<HotelInfo, HotelModel>())).Map<List<HotelModel>>(DataAccessFactory.HotelDataAccess().GetAll());
            return data;
        }

        public static List<string> GetNames()
        {
            var data = (from e in DataAccessFactory.HotelDataAccess().GetAll() select e.HotelName).ToList();
            return data;
        }
        public static bool Delete(int id)
        {
            try
            {
                DataAccessFactory.HotelDataAccess().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Edit(HotelModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<HotelModel, HotelInfo>())).Map<HotelInfo>(e);

            try
            {
                DataAccessFactory.HotelDataAccess().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(HotelModel e)

        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<HotelModel, HotelInfo>())).Map<HotelInfo>(e);

            try
            {
                DataAccessFactory.HotelDataAccess().Add(data);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static HotelModel Get(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<HotelInfo, HotelModel>())).Map<HotelModel>(DataAccessFactory.HotelDataAccess().Get(id));
            return data;
        }
    }
}
