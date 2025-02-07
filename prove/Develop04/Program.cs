
using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();
        Reference reference1 = new Reference();
        Reference reference2 = new Reference(5);

        reference1.Display();
        scripture1.Display();
        reference2.Display();

        scripture1.ConvertTextToList();

    }
    
}