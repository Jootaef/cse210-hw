namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        public int TimesRequired { get; set; }
        public int BonusPoints { get; set; }
        public int TimesCompleted { get; set; }

        public ChecklistGoal(string name, int points, int timesRequired, int bonusPoints) 
            : base(name, points)
        {
            TimesRequired = timesRequired;
            BonusPoints = bonusPoints;
            TimesCompleted = 0;
        }

        public override int RecordEvent()
        {
            TimesCompleted++;
            int totalPoints = Points;

            if (TimesCompleted == TimesRequired)
            {
                totalPoints += BonusPoints;
                IsCompleted = true;
            }

            return totalPoints;
        }

        public override string GetGoalInfo()
        {
            return $"{base.GetGoalInfo()} | {TimesCompleted}/{TimesRequired} Completed";
        }
    }
}
