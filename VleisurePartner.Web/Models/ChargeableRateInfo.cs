using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VleisurePartner.Web.Models
{
    public class ChargeableRateInfo
    {
        public string CurrencyCode { get; set; }
        public string Total { get; set; }
        public string Commission { get; set; }
    }
}