using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class HotelModel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public Nullable<int> TotalRooms { get; set; }
        public Nullable<int> AvailableRooms { get; set; }
        public Nullable<int> SingleRooms { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public Nullable<System.DateTime> ChecInDate { get; set; }
        public Nullable<System.DateTime> CheckOutDate { get; set; }
        public Nullable<double> SingeRoomPrice { get; set; }
        public Nullable<double> DoubleRoomPrice { get; set; }
        public Nullable<int> DoubleRooms { get; set; }
    }
}
