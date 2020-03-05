using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class ReferencessDTO
    {
        public int ReferenceId { get; set; }
        public int ReferenceCategoryId { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceDescription { get; set; }
        public string ReferenceLogo { get; set; }
    }
}
