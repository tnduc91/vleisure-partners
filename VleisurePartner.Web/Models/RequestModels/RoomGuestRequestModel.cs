using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;
namespace VleisurePartner.Web.Models
{
    public class RoomGuestRequestModel : ITypeProxy
    {
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; } // Api children does not have "s" for plural, then I dont put "s" here
        public List<int> ChildAges { get; set; } 
    }
}