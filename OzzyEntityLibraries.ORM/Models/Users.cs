using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public int UserRoleId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoto { get; set; }
        public string NameSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int TerritoryId { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
    }
}
