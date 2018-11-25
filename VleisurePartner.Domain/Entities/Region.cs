namespace VleisurePartner.Domain.Entities
{

    public class Region
    {
        public int RegionId { get; set; } // RegionID (Primary key)
        public string RegionType { get; set; } // RegionType
        public string RelativeSignificance { get; set; } // RelativeSignificance
        public string SubClass { get; set; } // SubClass
        public string RegionName { get; set; } // RegionName
        public string RegionNameLong { get; set; } // RegionNameLong
        public string ParentRegionType { get; set; } // ParentRegionType
        public string ParentRegionName { get; set; } // ParentRegionName
        public string ParentRegionNameLong { get; set; } // ParentRegionNameLong
        public string CountryName { get; set; } // CountryName
        public string CountryCode { get; set; } // CountryCode
    }

}
