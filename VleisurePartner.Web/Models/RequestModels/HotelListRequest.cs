using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models.RequestModels
{
    public class HotelListRequest : GenericRequest, ITypeProxy
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string LanguageCode { get; set; }
        public string CityCode { get; set; }
        public IEnumerable<int> HotelIds { get; set; }
        public IEnumerable<RoomGuestRequestModel> RoomGuests { get; set; }

     
    }
}