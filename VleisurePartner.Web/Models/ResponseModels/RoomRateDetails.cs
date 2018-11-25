using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models.ResponseModels
{
    public class RoomRateDetails : ITypeProxy 
    {
        public string Token { get; set; }
        public string[] RoomTypeCode { get; set; }
        public string[] RateCode { get; set; }
        public int MaxRoomOccupancy { get; set; }
        public int QuotedRoomOccupancy { get; set; }
        public int MinGuestAge { get; set; }
        public string[] RoomDescription { get; set; }
        public IEnumerable<BedType> BedTypes { get; set; }
        public RateInfo RateInfos { get; set; }
        public List<ValueAdd> ValueAdds { get; set; }
    }
}