namespace EternalQuest.Utils
{
    public static class DisplayManager
    {
        public static void DisplayGoals(List<Goal> goals)
        {
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.GetGoalInfo());
            }
        }
    }
}
