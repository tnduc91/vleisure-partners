using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;
namespace VleisurePartner.Web.Models.ResponseModels
{
    public class ChargeableRateInfo : ITypeProxy
    {
        public string CurrencyCode { get; set; }
        public string Total { get; set; }
        public string Commission { get; set; }
    }
}