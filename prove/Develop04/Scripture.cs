using System;

class Scripture
{
    private string text;

    public Scripture()
    {
        text = "8 But as oft as they repented and sought forgiveness, with real intent, they were forgiven.";
    }

    public void Display()
    {
        Console.WriteLine(text);
    }


    public void ConvertTextToList()
    {
        List<string> wordList = new List<string>(text.Split(' '));
    }
}