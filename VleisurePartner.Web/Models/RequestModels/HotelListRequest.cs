using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VleisurePartner.Web.Models
{
    public class HotelListRequest : GenericRequest
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string CityCode { get; set; }
        public IEnumerable<int> HotelIds { get; set; }
        public List<RoomGuestRequestModel> RoomGuests { get; set; }
    }
}