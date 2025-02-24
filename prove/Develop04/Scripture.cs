using System;
using System.Collections.Generic;

class Scripture
{
    private string _text;
    private List<Word> _list = new List<Word>();

    public Scripture()
    {
        _text = "But as oft as they repented and sought forgiveness, with real intent, they were forgiven.";
    }

       public Scripture(string inputText)
    {
        _text = inputText;
    }

    public void ConvertTextToList()
    {

        foreach (string text in _text.Split(' '))
        {
            Word wordObject = new Word(text);
            _list.Add(wordObject);
        }

    }

    public void Blank()
    {
        Random RNG = new Random();

        for (int i = 0; i < 3; i++)
        {
            int range = RNG.Next(0, _list.Count);
            _list[range].SetVisibility(false);
        }
    }

    public void Display()
    {
        foreach (Word word in _list)
        {
            word.Display();
            Console.Write(" ");
        }
    }
}