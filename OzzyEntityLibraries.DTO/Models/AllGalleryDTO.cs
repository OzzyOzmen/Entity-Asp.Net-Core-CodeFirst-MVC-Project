using System;
using System.Collections.Generic;
using OzzyEntityLibraries.DTO.Models;
namespace OzzyEntityLibraries.DTO.Models
{
    public class AllGalleryDTO
    {
         public List<GalleryCategoriesDTO> galleryCategoriesDTOs { get; set; }
        public int selectedIndex { set; get; }
        public GalleriesDTO galleriesDTO { get; set; }
    
    }
}
