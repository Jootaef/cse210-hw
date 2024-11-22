using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine(string.Join(" ", _words));
    }

    public bool HideWords()
    {
        var visibleWords = _words.FindAll(word => !word.IsHidden);
        if (visibleWords.Count == 0)
        {
            return false;
        }

        Random random = new Random();
        int wordsToHide = Math.Min(3, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }

        return true;
    }
}
