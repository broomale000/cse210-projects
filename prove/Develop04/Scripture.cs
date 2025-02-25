using System;
using System.Collections.Generic;

class Scripture
{
    private string _text;
    private List<Word> _list = new List<Word>();
    private int count = 3;
    private Random RNG = new Random();
    private HashSet<int> selectedIndexes = new HashSet<int>();

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
        if (selectedIndexes.Count != _list.Count)
        {
            while (count != 0)
            {
                if (selectedIndexes.Count == _list.Count){
                    break;
                }
                int range = RNG.Next(0, _list.Count);
                if (!selectedIndexes.Contains(range))
                {
                    _list[range].SetVisibility(false);
                    selectedIndexes.Add(range);
                    count = count - 1;
                }
            }
            count = 3;
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