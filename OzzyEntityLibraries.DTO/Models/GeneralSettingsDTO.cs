using System;
using System.Collections.Generic;

namespace OzzyEntityLibraries.DTO.Models
{
    public partial class GeneralSettingsDTO
    {
      public int GeneralSettingsId { get; set; }
        public string WebSiteName { get; set; }
        public string WebSiteAddress { get; set; }
        public string Keywords { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }
        public string SmtpAddress { get; set; }
        public string SmtpPort { get; set; }
        public string CompanyAddress { get; set; }
        public string Phone { get; set; }
        public string SiteLogo { get; set; }
    }
}
