using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Regions
    {
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public string RegionName { get; set; }
    }
}
