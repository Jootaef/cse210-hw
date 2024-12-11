using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goal> goals = new List<Goal>();
            int userScore = 0;
            int userLevel = 1;

            SimpleGoal marathonGoal = new SimpleGoal("Run a marathon", 1000);
            goals.Add(marathonGoal);
            userScore += marathonGoal.RecordEvent();

            EternalGoal scriptureGoal = new EternalGoal("Read scriptures", 100);
            goals.Add(scriptureGoal);
            userScore += scriptureGoal.RecordEvent();

            ChecklistGoal templeGoal = new ChecklistGoal("Attend the temple", 50, 10, 500);
            goals.Add(templeGoal);
            userScore += templeGoal.RecordEvent();

            NegativeGoal badHabitGoal = new NegativeGoal("Stop a bad habit", 200);
            goals.Add(badHabitGoal);
            userScore += badHabitGoal.RecordEvent();

            userLevel = CalculateLevel(userScore);

            Console.WriteLine($"Total score: {userScore}");
            Console.WriteLine($"Level: {userLevel}");

            DisplayGoals(goals);
            CheckMilestones(userScore);
        }

        static int CalculateLevel(int score)
        {
            return score / 1000 + 1;
        }

        static void DisplayGoals(List<Goal> goals)
        {
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.GetGoalInfo());
            }
        }

        static void CheckMilestones(int score)
        {
            if (score >= 5000)
            {
                Console.WriteLine("Congratulations! You've reached a major milestone!");
            }
        }
    }
}
