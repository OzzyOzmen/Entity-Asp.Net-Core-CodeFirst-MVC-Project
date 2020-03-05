using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class GalleriesDTO
    {
        public int GalleryId { get; set; }
        public int GalleryCategoryId { get; set; }
        public string GalleryName { get; set; }
        public string GalleryPhoto { get; set; }
    }
}
