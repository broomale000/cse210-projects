using System;

class Reference
{
    private string text;
    private int storage;

    public Reference()
    {
        text = "Moroni 6:8";
    }

    public Reference(int number)
    {
        storage = number;
        text = "Moroni 6:7-8";
    }


    public void Display()
    {
        Console.WriteLine(text);
    }
}