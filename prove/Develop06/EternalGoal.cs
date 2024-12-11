namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) {}

        public override int RecordEvent()
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                return Points;
            }
            return 0;
        }

        public override string GetGoalInfo()
        {
            return base.GetGoalInfo() + " | Eternal Goal";
        }
    }
}
