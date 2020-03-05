using System;
namespace OzzyEntityLibraries.DTO.Models
{
    public partial class SmsSenderDTO
    {
        public int RegionId { get; set; }
        public string UserCode { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string OrginatorTitle { get; set; }
        public string CharacterType { get; set; }
        public string SmsDescription { get; set; }

    }
}
