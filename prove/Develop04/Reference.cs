using System;

class Reference
{
    private string text;

    public Reference()
    {
        text = "Moroni 6:8";
    }

    public Reference (string inputText)
    {
        text = inputText;
    }

    public void Display()
    {
        Console.WriteLine(text);
    }
}