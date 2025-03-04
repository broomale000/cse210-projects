using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup
        Console.Clear();
        Menu menu = new Menu();
            
        // While loop that displays options and returns to menu when finished
        while (true)
        {
            Console.WriteLine("");
            menu.Display();
            Console.Write("\nPlease selection an option: ");
            string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("One");
                    Console.WriteLine("");
                    Activity FirstActivity = new Activity();
                    FirstActivity.GetReady(5);
                }
                else if (input == "2")
                {
                    Breathing BreathingActivity = new Breathing();
                    BreathingActivity.BreathingIntro();
                    BreathingActivity.SetSessionDuration();
                    BreathingActivity.GetReady(5);
                    BreathingActivity.BreatheInOut();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Three");
                    Console.WriteLine("");
                }
                else if (input == "4")
                {
                    Console.WriteLine("Four");
                    Console.WriteLine("");
                    break;
                }
                else
                {
                    Console.WriteLine("Error.");
                }
        }
        Console.WriteLine("\nThank you for doing Mindfulness with us today!");
    }
}