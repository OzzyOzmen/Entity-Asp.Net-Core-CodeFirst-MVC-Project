using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class AllOrderDetails
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public short Discount { get; set; }
    }
}
