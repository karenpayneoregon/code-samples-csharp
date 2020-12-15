using System;

namespace PersonalData.Classes.Containers
{
    [Newtonsoft.Json.JsonObject(Title = "Techprofile")]
    public class TechProfile
    {
        public string Email { get; set; }
        public string Locale { get; set; }
        public string Country { get; set; }
        public string ContactPointTopicSetting { get; set; }
        public bool Gsi { get; set; }
        public object IsAvatarTakenDown { get; set; }
        public object Source { get; set; }
        public object AcceptedPrivacyNotice { get; set; }
        public Authenticationmode[] AuthenticationModes { get; set; }
        public object Interests { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string AvatarUrl { get; set; }
        public string AvatarThumbnailUrl { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsMicrosoftUser { get; set; }
        public bool IsMvp { get; set; }
        public string QnaUserId { get; set; }
        public int FollowerCount { get; set; }
        public int FollowingCount { get; set; }
        public int AnswersAccepted { get; set; }
        public int ReputationPoints { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}