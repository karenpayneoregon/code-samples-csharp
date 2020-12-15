using System;

namespace PersonalData.Classes.Containers
{
    public class Authenticationmode
    {
        public string id { get; set; }
        public string type { get; set; }
        public string tenantId { get; set; }
        public string upn { get; set; }
        public object dateAcceptedPrivacyNotice { get; set; }
        public DateTime DateAdded { get; set; }
    }
}