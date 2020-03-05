using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Territories
    {
        public int TerritoryId { get; set; }
        public int RegionId { get; set; }
        public string TerritoryName { get; set; }
    }
}
