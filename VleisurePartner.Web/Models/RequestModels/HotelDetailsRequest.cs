using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models.RequestModels
{
    public class HotelDetailsRequest : GenericRequest, ITypeProxy
    {
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string LanguageCode { get; set; }
        public string HotelId { get; set; }
        public List<RoomGuestRequestModel> RoomGuests { get; set; }
    }
}