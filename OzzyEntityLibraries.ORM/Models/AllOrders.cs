using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class AllOrders
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippingDate { get; set; }
        public string ShippingCost { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }
        public string TerritoryName { get; set; }
        public string RegionName { get; set; }
        public string CountryName { get; set; }
        public string ShippingPostalCode { get; set; }
    }
}
