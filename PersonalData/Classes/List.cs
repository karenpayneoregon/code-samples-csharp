using System;
using Newtonsoft.Json;

namespace PersonalData.Classes
{
    public class List
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "lastModified")]
        public DateTime LastModified { get; set; }
        [JsonProperty(PropertyName = "items")]
        public object[] Items { get; set; }
        [JsonProperty(PropertyName = "isOfficial")]
        public bool IsOfficial { get; set; }
        [JsonProperty(PropertyName = "challengeId")]
        public object ChallengeId { get; set; }
    }
}