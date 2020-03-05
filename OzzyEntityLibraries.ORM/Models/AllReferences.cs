using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class AllReferences
    {
        public int ReferenceId { get; set; }
        public string ReferenceCategoryName { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceDescription { get; set; }
        public string ReferenceLogo { get; set; }
    }
}
