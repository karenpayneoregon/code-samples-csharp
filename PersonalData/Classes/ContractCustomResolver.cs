using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace PersonalData.Classes
{
    public class ContractCustomResolver : DefaultContractResolver
    {
        private Dictionary<string, string> PropertyMappings { get; set; }

        public ContractCustomResolver()
        {
            PropertyMappings = new Dictionary<string, string>
            {
                {"Email", "email"},
                {"AcceptedPrivacyNotice", "acceptedPrivacyNotice"},
                {"Locale", "locale"},
                {"Country", "country"},
                {"ContactPointTopicSetting", "contactPointTopicSetting"},
                {"Gsi", "gsi"},
                {"IsAvatarTakenDown", "isAvatarTakenDown"},
                {"Source", "source"},
                {"AuthenticationModes", "authenticationModes"},
                {"Interests", "interests"},
                {"UserId", "userId"},
                {"UserName", "userName"},
                {"DisplayName", "displayName"},
                {"AvatarUrl", "avatarUrl"},
                {"AvatarThumbnailUrl", "AvatarThumbnailUrl"},
                {"IsPrivate", "isPrivate"},
                {"IsMicrosoftUser", "isMicrosoftUser"},
                {"IsMvp", "isMvp"},
                {"QnaUserId", "qnaUserId"},
                {"FollowerCount", "followerCount"},
                {"AnswersAccepted", "answersAccepted"},
                {"ReputationPoints", "reputationPoints"},
                {"CreatedOn", "createdOn"},
                {"DateAdded", "dateAdded"},
                {"TotalPoints", "totalPoints"},
                {"Achievements", "achievements"},
                {"Title", "title"},
            };
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            string resolvedName = null;
            var resolved = PropertyMappings.TryGetValue(propertyName, out resolvedName);
            return (resolved) ? resolvedName : base.ResolvePropertyName(propertyName);
        }
    }
}
