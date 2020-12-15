﻿using Newtonsoft.Json;
namespace PersonalData.Classes
{
    public class Assessments
    {
        [JsonProperty(PropertyName = "sessions")]
        public object[] Sessions { get; set; }
        [JsonProperty(PropertyName = "sessionProviderData")]
        public object[] SessionProviderData { get; set; }
    }
}