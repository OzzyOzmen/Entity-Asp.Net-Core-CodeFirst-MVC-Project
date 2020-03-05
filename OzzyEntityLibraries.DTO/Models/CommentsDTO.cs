using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class CommentsDTO
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentDiscription { get; set; }
    }
}
