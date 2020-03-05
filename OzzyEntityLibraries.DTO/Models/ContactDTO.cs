using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class ContactDTO
    {
        public int ContactId { get; set; }
        public string Sender { get; set; }
        public string ContactMessage { get; set; }
        public string SendingDate { get; set; }
        public bool? IsRead { get; set; }
    }
}
