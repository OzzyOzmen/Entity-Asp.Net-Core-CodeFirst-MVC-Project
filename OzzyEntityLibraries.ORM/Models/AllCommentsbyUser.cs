using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class AllCommentsbyUser
    {
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentDiscription { get; set; }
    }
}
