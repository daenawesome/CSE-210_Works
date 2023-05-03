using System;
using System.Collections.Generic;

public class Verse
{
    private string reference;
    private List<Word> words;

    public Verse(string reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }
        if (visibleIndices.Count > 0)
        {
            int indexToHide = visibleIndices[new Random().Next(visibleIndices.Count)];
            words[indexToHide].Hide();
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        string output = reference + ": ";
        foreach (Word word in words)
        {
            output += word.ToString() + " ";
        }
        return output;
    }
}
