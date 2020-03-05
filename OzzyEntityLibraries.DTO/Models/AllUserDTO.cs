using System;
using System.Collections.Generic;
using OzzyEntityLibraries.DTO.Models;

namespace OzzyEntityLibraries.DTO.Models
{
    public class AllUserDTO
    {
        public List<TerritoriesDTO> territoriesDTOs { get; set; }
        public List<RegionsDTO> regionsDTOs { get; set; }
        public List<CountriesDTO> countriesDTOs { get; set; }
        public List<UserRolesDTO> userRolesDTO { get; set; }
        public UsersDTO usersDTO { get; set; }
        public int selectedIndex { set; get; }
        public int selectedIndex2 { set; get; }
        public int selectedIndex3 { set; get; }
        public int selectedIndex4 { set; get; }
    }
}
