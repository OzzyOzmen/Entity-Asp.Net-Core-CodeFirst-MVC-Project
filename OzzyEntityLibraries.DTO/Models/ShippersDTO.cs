using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class ShippersDTO
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
