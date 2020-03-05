using System;
using System.Collections.Generic;
using OzzyEntityLibraries.DTO.Models;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class AllPostsDTO
    {
        public List<PostCategoriesDTO> postCategoriesDTOs { get; set; }
        public int selectedIndex { set; get; }
        public PostsDTO postsDTO { get; set; }
    }
}
