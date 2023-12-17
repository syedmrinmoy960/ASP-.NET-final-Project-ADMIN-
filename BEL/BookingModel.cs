using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BookingModel
    {
        public int BokkingId { get; set; }
        public int UserId { get; set; }
        public int HotelId { get; set; }
        public Nullable<int> RoomDescripsion { get; set; }
        public Nullable<int> RoomType { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> CurrentAmount { get; set; }
        public Nullable<System.DateTime> CheckIn { get; set; }
        public Nullable<System.DateTime> CheckOut { get; set; }
    }
}
