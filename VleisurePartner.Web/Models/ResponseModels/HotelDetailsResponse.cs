using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;
namespace VleisurePartner.Web.Models.ResponseModels
{
    public class HotelDetailsResponse : ITypeProxy
    {
        public string Status { get; set; }
        public HotelDetails RoomAvailRs { get; set; }

    }
}