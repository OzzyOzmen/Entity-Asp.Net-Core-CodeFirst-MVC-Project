using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class PagesDTO
    {
        public int PageId { get; set; }
        public string Pagetitle { get; set; }
        public string PageDescription { get; set; }
        public string Photo { get; set; }
        public string PageUrl { get; set; }
    }
}
