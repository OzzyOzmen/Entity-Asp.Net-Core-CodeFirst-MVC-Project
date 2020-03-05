using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string NameSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string Birthday { get; set; }
        public string HireDate { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserPhoto { get; set; }
        public int? TerritoryId { get; set; }
        public int? RegionId { get; set; }
        public int? CountryId { get; set; }
    }
}
