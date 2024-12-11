namespace EternalQuest
{
    public class NegativeGoal : Goal
    {
        public NegativeGoal(string name, int points) : base(name, points) {}

        public override int RecordEvent()
        {
            if (!IsCompleted)
            {
                IsCompleted = true;
                return -Points;
            }
            return 0;
        }

        public override string GetGoalInfo()
        {
            return base.GetGoalInfo() + " | Negative Goal (Lose Points)";
        }
    }
}
