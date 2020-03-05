using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class PostsDTO
    {
        public int PostId { get; set; }
        public int PostCategoryId { get; set; }
        public string PostTitle { get; set; }
        public string PostDiscription { get; set; }
        public string PostPhoto { get; set; }
    }
}
