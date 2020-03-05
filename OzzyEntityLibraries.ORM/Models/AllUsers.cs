using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class AllUsers
    {
        public int UserId { get; set; }
        public string UserRole { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public string UserPhoto { get; set; }
        public string TerritoryName { get; set; }
        public string RegionName { get; set; }
        public string CountryName { get; set; }
    }
}
