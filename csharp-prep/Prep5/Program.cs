using System;

class Program
{
    static void Main(string[] args)
    {
        ShowWelcomeMessage();

        string name = GetUserInputName();
        int favoriteNumber = GetUserFavoriteNumber();

        int result = CalculateSquare(favoriteNumber);

        PrintFinalResult(name, result);
    }

    static void ShowWelcomeMessage()
    {
        Console.WriteLine("Hello! Welcome to this awesome program.");
    }

    static string GetUserInputName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int GetUserFavoriteNumber()
    {
        Console.Write("What is your favorite number? ");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
    }

    static int CalculateSquare(int num)
    {
        int squaredValue = num * num;
        return squaredValue;
    }

    static void PrintFinalResult(string userName, int squareValue)
    {
        Console.WriteLine($"{userName}, the square of your favorite number is {squareValue}");
    }
}
