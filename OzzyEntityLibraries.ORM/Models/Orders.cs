using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int ShipperId { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippingDate { get; set; }
        public string ShippingCost { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress { get; set; }
        public int ShippingTerritoryId { get; set; }
        public int ShippingRegionId { get; set; }
        public int ShippingCountryId { get; set; }
        public string ShippingPostalCode { get; set; }
    }
}
