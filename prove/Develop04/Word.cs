using System;
using System.Collections.Generic;

class Word
{
    private string word;
    private bool visible;

    public Word(string input)
    {
        word = input;
        visible = true;
    }

    public void Display()
    {
        Console.Write(visible ? word : new string('_', word.Length));
    }

    public void SetVisibility(bool isVisible)
    {
        visible = isVisible;
    }
}