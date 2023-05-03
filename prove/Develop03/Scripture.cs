using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Verse> verses;

    public Scripture(string reference, string text)
    {
        verses = new List<Verse>();
        verses.Add(new Verse(reference, text));
    }

    public Scripture(string reference, string[] texts)
    {
        verses = new List<Verse>();
        for (int i = 0; i < texts.Length; i++)
        {
            verses.Add(new Verse(reference + "-" + (i + 1), texts[i]));
        }
    }

    public void HideRandomWord()
    {
        foreach (Verse verse in verses)
        {
            verse.HideRandomWord();
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Verse verse in verses)
        {
            if (!verse.IsFullyHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void Print()
    {
        Console.Clear();
        foreach (Verse verse in verses)
        {
            Console.WriteLine(verse.ToString());
        }
    }
}
