using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Galleries
    {
        public int GalleryId { get; set; }
        public int GalleryCategoryId { get; set; }
        public string GalleryName { get; set; }
        public string GalleryPhoto { get; set; }
    }
}
