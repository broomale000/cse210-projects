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
                    Breathing BreathingActivity = new Breathing();
                    BreathingActivity.BreathingIntro();
                    BreathingActivity.SetSessionDuration();
                    BreathingActivity.BreatheInOut();                  
                }
                else if (input == "2")
                {
                    Reflection ReflectionActivity = new Reflection();
                    ReflectionActivity.ReflectionIntro();
                    ReflectionActivity.SetSessionDuration();
                    ReflectionActivity.ReflectIn();
                }
                else if (input == "3")
                {
                    Listing ListingActivity = new Listing();
                    ListingActivity.ListingIntro();
                    ListingActivity.SetSessionDuration();
                    ListingActivity.ListOut();
                }
                else if (input == "4")
                {
                    Console.WriteLine("\nThank you for doing Mindfulness with us today!");
                    break;
                }
                else
                {
                    Console.WriteLine("Error.");
                }
        }
        
                    // Console.Clear();
                    // Console.WriteLine("One");
                    // Console.WriteLine("");
                    // Activity FirstActivity = new Activity();
                    // FirstActivity.GetReady(5);
    }
}