using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;

namespace VleisurePartner.Web.Models.ResponseModels
{
    public class RateInfo : ITypeProxy
    {
        public bool PriceBreakDown { get; set; }
        public bool Promo { get; set; }
        public bool RateChange { get; set; }
        public RoomGroup[] RoomGroup { get; set; }
        public ChargeableRateInfo ChargeableRateInfo { get; set; }
        public bool NonRefundable { get; set; }
        public string PromoDescription { get; set; }
        public string CurrentAllotment { get; set; }
        public string CancellationList { get; set; }
    }
}