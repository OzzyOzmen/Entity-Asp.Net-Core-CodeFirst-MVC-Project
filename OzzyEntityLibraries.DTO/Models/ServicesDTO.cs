using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class ServicesDTO
    {
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public string Photo { get; set; }
    }
}
