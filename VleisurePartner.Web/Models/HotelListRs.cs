using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models
{
    public class HotelListRs : ITypeProxy
    {
        public List<HotelDetails> HotelSummary { get; set; }
    }
}