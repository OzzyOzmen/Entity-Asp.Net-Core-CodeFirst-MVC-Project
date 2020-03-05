namespace OzzyEntityLibraries.DTO.Models
{
    public partial class AllCustomersDTO
    {
         public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string RegionName { get; set; }
        public string TerritoryName { get; set; }
        public string CountryName { get; set; }
    }
}