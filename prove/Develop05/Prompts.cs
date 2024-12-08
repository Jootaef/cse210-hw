using System;

class Prompts
{
    public static string GetRandomPrompt(string[] prompts)
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
}
