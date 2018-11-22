using System.Collections.Generic;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models.ResponseModels
{
    public class HotelDetails : ITypeProxy
    {
        public string HotelId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string CountryCode { get; set; }
        public string AirportCode { get; set; }
        public string CityCode { get; set; }
        public string SessionId { get; set; }
        public string PropertyCategory { get; set; }
        public string HotelRating { get; set; }
        public string HotelRatingDisplay { get; set; }
        public string ConfidenceRating { get; set; }
        public string AmenityMask { get; set; }
        public string LocationDescription { get; set; }
        public string ShortDescription { get; set; }
        public string HighRate { get; set; }
        public string LowRate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ProximityDistance { get; set; }
        public string ProximityUnit { get; set; }
        public string HotelInDestination { get; set; }
        public string ThumbNailUrl { get; set; }
        public string CheckInInstructions { get; set; }
        public string SpecialCheckInInstructions { get; set; }
        public List<RoomRateDetails> RoomRateDetailsList { get; set; }
    }
}