using System;

namespace PersonalData.Classes.Containers
{
    public class XP
    {
        public int TotalPoints { get; set; }
        public Level level { get; set; }
        public DateTime levelAchievedDateUTC { get; set; }
        public int nextLevelNumber { get; set; }
        public int currentLevelPointsEarned { get; set; }
        public int pointsToNextLevel { get; set; }
        public object[] Achievements { get; set; }
    }
}