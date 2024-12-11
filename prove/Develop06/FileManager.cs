using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EternalQuest.Utils
{
    public static class FileManager
    {
        public static void SaveGoals(List<Goal> goals, int score)
        {
            using (FileStream fs = new FileStream("goals.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, goals);
                formatter.Serialize(fs, score);
            }
        }

        public static (List<Goal>, int) LoadGoals()
        {
            using (FileStream fs = new FileStream("goals.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Goal> goals = (List<Goal>)formatter.Deserialize(fs);
                int score = (int)formatter.Deserialize(fs);
                return (goals, score);
            }
        }
    }
}
