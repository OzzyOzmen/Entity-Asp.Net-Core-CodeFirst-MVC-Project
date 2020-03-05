using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.ORM.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string Sender { get; set; }
        public string ContactMessage { get; set; }
        public string SendingDate { get; set; }
        public bool? IsRead { get; set; }
    }
}
