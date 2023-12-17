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
      public class BookingService
    {
        public static List<BookingModel> GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Booking, BookingModel>())).Map<List<BookingModel>>(DataAccessFactory.BookingDataAccess().GetAll());
            return data;
        }
    }
}
