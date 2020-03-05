using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductName { get; set; }
        public short? StockQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public string ShowCasePhoto { get; set; }
        public string ProductPhoto { get; set; }
    }
}
