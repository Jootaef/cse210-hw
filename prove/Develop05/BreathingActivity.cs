using System;

class BreathingActivity : Activity
{
    public override void StartActivity()
    {
        StartMessage("Breathing Activity", "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breath.");
        for (int i = 0; i < Duration; i += 6)
        {
            Console.WriteLine("Breathe in...");
            PauseWithSpinner(3);
            Console.WriteLine("Breathe out...");
            PauseWithSpinner(3);
        }
        EndMessage("Breathing Activity");
    }
}
