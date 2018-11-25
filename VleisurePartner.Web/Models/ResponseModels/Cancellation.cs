using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models.ResponseModels
{
    public class Cancellation : ITypeProxy
    {
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime DateFrom { get; set; }
        public string TimeZoneDescription { get; set; }
    }
}