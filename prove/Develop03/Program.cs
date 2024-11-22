using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Psalms", 23, 1), "The Lord is my shepherd, I lack nothing."),
            new Scripture(new Reference("Proverbs", 3, 5, 3, 6), "Trust in the Lord with all your heart and lean not on your own understanding.")
        };

        Random random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        Console.Clear();
        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine("====================\n");

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
            {
                Console.WriteLine("Thanks for using the Scripture Memorizer. Goodbye!");
                break;
            }

            if (!scripture.HideWords())
            {
                Console.WriteLine("All words are hidden! Great job!");
                break;
            }

            Console.Clear();
        }
    }
}
