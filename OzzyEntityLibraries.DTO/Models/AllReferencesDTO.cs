using System;
using System.Collections.Generic;
using OzzyEntityLibraries.DTO.Models;
namespace OzzyEntityLibraries.DTO.Models
{
    public class AllReferencesDTO
    {
        public List<ReferenceCategoriesDTO> referenceCategoriesDTO { get; set; }
        public int selectedIndex { set; get; }
        public ReferencessDTO referencessDTO { get; set; }
    }
}
