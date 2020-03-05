using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class AboutUs
    {
        public int AboutUsId { get; set; }
        public string AboutUsTitle { get; set; }
        public string AboutUsDescription { get; set; }
        public string Photo { get; set; }
    }
}
