
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference1 = new Reference();
        reference1.Display();
        Scripture scripture1 = new Scripture();
        scripture1.ConvertTextToList();
        scripture1.Display();
        
        Console.WriteLine();
        Console.WriteLine();

        Reference reference2 = new Reference("Moroni 6:7-8");
        reference2.Display();
        Scripture scripture2 = new Scripture("And they were strict to observe that there should be no iniquity among them; and whoso was found to commit iniquity, and three witnesses of the church did condemn them before the elders, and if they repented not, and confessed not, their names were blotted out, and they were not numbered among the people of Christ. But as oft as they repented and sought forgiveness, with real intent, they were forgiven.");
        scripture2.ConvertTextToList();
        scripture2.Display();

            while (true)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 'Enter' to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                reference1.Display();
                scripture1.Blank();
                scripture1.Display();
                Console.WriteLine();
                Console.WriteLine();
                reference2.Display();
                scripture2.Blank();
                scripture2.Display();
            }
        }
    }
    
}