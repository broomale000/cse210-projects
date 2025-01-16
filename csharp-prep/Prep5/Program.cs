using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program! ");
        }
        DisplayMessage();

        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        string returnedName = PromptUserName();

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            string userNumber = Console.ReadLine();
            int userProcessedNumber = int.Parse(userNumber);
            int squaredNum = userProcessedNumber * userProcessedNumber;
            return squaredNum;
        }
        int returnedSquare = PromptUserNumber();

        Console.WriteLine("Input a number to square: ");
        string userSquareRawInput = Console.ReadLine();
        int userSquareProcessedInput = int.Parse(userSquareRawInput);

        static int SquareNumber(int number)
        {
            int product = number * number;
            return product;
        }



        static void DisplayResult(string returnedName, int returnedSquare)
        {
            Console.WriteLine($"This is displaying your name: {returnedName}");
            Console.WriteLine($"This is displaying your favorite number squared: {returnedSquare}");
        }
        DisplayResult(returnedName, returnedSquare);

    }
    
}