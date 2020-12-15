using System;

namespace PersonalData.Classes.Containers
{
    [Newtonsoft.Json.JsonObject(Title = "Completedlearningitem")]
    public class CompletedLearningItem
    {
        public string Title { get; set; }
        public string type { get; set; }
        public DateTime completedAt { get; set; }
    }
}