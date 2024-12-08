using System;

class ReflectionActivity : Activity
{
    private string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind?"
    };

    public override void StartActivity()
    {
        StartMessage("Reflection Activity", "This activity will help you reflect on times of strength and resilience.");
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        PauseWithSpinner(5);

        for (int i = 0; i < Duration; i += 10)
        {
            Console.WriteLine(Questions[random.Next(Questions.Length)]);
            PauseWithSpinner(10);
        }
        EndMessage("Reflection Activity");
    }
}
