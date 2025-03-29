using System;

class Program
{
    static void Main(string[] args)
    {
        string _userInput = "";

        Menu MainMenu = new Menu();
        MainMenu.Display();
        _userInput = Console.ReadLine();
        while (true)
        {
            if (_userInput == "1") // Create New Goals
            {
                string _userInput2 = "";

                MainMenu.DisplayBranch();
                _userInput2 = Console.ReadLine();

                // Simple / Eternal / Checklist
                if (_userInput2 == "1")
                {
                    // Simple Goal
                }
                if (_userInput2 == "2")
                {
                    // Eternal Goal
                    
                }
                if (_userInput2 == "3")
                {
                    // Checklist Goal
                }


            }
            if (_userInput == "2") // List Goals
            {
                
            }
            if (_userInput == "3") // Save Goals
            {
                
            }
            if (_userInput == "4") // Load Goals
            {
                
            }
            if (_userInput == "5") // Record Event
            {
                
            }
            if (_userInput == "6") // Quit
            {
                Console.WriteLine("Thank you for making Goals with us today! ");
                break;
            }
        }
    }
}