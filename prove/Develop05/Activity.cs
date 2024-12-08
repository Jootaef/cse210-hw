using System;

abstract class Activity
{
    protected int Duration;

    public void StartMessage(string name, string description)
    {
        Console.Clear();
        Console.WriteLine($"Starting {name}");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    public void EndMessage(string name)
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {name} for {Duration} seconds.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void StartActivity();
}
