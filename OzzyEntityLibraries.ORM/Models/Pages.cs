using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Pages
    {
        public int PageId { get; set; }
        public string Pagetitle { get; set; }
        public string PageDescription { get; set; }
        public string Photo { get; set; }
        public string PageUrl { get; set; }
    }
}
