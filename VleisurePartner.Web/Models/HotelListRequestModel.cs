using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VleisurePartner.Web.Models
{
    public class HotelListRequestModel : RequestBody
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public IEnumerable<int> HotelIds { get; set; }
        public IEnumerable<RoomGuestRequestModel> RoomGuests { get; set; }
    }
}