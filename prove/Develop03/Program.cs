
using System;

class Program
{
    static Journal myJournal = new Journal();

    static void Main()
    {
        while(true)
        {
            Menu.Display();
            string userSelect = Console.ReadLine();
            Console.WriteLine();

            switch (userSelect)
            {
                case "1":
                    Manager.WriteNewEntry(myJournal);
                    break;
                case "2":
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    Manager.SaveJournal(myJournal);
                    break;
                case "4":
                    Console.WriteLine("Please input file name");
                    string filename = Console.ReadLine();
                    Manager.LoadJournal(filename);
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