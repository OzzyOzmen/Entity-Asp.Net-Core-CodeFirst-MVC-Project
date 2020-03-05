using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class AllGalleries
    {
        public int GalleryId { get; set; }
        public string GalleryCategoryName { get; set; }
        public string GalleryName { get; set; }
        public string GalleryPhoto { get; set; }
    }
}
