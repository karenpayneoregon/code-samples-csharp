using System;

namespace PersonalData.Classes
{
    public class XP
    {
        public int totalPoints { get; set; }
        public Level level { get; set; }
        public DateTime levelAchievedDateUTC { get; set; }
        public int nextLevelNumber { get; set; }
        public int currentLevelPointsEarned { get; set; }
        public int pointsToNextLevel { get; set; }
        public object[] achievements { get; set; }
    }
}