
using System;
using System.ComponentModel;

class Program
{

    static List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static Journal myJournal = new Journal();

    static void Main()
    {
        while(true)
        {
            Menu.Display();
            string userSelect = Console.ReadLine();

            switch (userSelect)
            {
                case "1":
                    Manager.WriteNewEntry();
                    break;
                case "2":
                    Console.WriteLine("Empty");;
                    break;
                case "3":
                    Console.WriteLine("Empty");
                    break;
                case "4":
                    Console.WriteLine("Empty");
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        }
        
    }


}