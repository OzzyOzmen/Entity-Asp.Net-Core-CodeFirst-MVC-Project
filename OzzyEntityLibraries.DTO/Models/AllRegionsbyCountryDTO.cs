using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class AllRegionsbyCountryDTO
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public string CountryName { get; set; }
    }
}
