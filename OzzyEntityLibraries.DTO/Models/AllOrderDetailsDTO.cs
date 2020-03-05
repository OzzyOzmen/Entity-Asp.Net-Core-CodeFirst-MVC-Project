using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class AllOrderDetailsDTO
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public short Discount { get; set; }
    }
}
