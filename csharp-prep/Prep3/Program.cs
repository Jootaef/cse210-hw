using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int targetNumber = rand.Next(1, 101);

        int userGuess = 0;

        while (userGuess != targetNumber)
        {
            Console.Write("Enter your guess: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < targetNumber)
            {
                Console.WriteLine("Try a higher number");
            }
            else if (userGuess > targetNumber)
            {
                Console.WriteLine("Try a lower number");
            }
            else
            {
                Console.WriteLine("Congratulations, you've guessed the number!");
            }
        }
    }
}
