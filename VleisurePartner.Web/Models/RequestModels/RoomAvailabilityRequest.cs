using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models.RequestModels
{
    public class RoomAvailabilityRequest : GenericRequest, ITypeProxy
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public int HotelId { get; set; }
        public string CityCode { get; set; }
        public string Token { get; set; }
        public string SessionId { get; set; }
        public IEnumerable<RoomGuestRequestModel> RoomGuests { get; set; }
        public IEnumerable<string> RoomTypeCode { get; set; }
        public IEnumerable<string> RateCode { get; set; }
    }
}