using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VleisurePartner.Web.Models
{
    public class HotelListResponseModel
    { 
        public IEnumerable<HotelResponseModel> Hotels { get; set; }
    }
}