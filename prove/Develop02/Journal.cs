using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> _entries;
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("\nPrompt: " + prompt);

        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();
        _entries.Add(new JournalEntry(date, prompt, response));
        Console.WriteLine("\nEntry added successfully!");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nYour Journal Entries:\n");
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("\nEnter the filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
            }
        }
        Console.WriteLine("\nJournal saved successfully!");
    }

    public void LoadJournalFromFile()
    {
        Console.Write("\nEnter the filename to load the journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split("~|~");
                if (parts.Length == 3)
                {
                    _entries.Add(new JournalEntry(parts[0], parts[1], parts[2]));
                }
            }
            Console.WriteLine("\nJournal loaded successfully!");
        }
        else
        {
            Console.WriteLine("\nFile not found.");
        }
    }
}
