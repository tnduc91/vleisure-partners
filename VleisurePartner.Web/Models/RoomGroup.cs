using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models
{
    public class RoomGroup : ITypeProxy
    {
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public string RateKey { get; set; }
    }
}