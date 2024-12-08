using System;

class ListingActivity : Activity
{
    private string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void StartActivity()
    {
        StartMessage("Listing Activity", "This activity will help you reflect on positive things in your life.");
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        PauseWithSpinner(5);

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndMessage("Listing Activity");
    }
}
