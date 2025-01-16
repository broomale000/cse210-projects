using System;

class Program
{
    static void Main(string[] args)
    {
                Random rnd = new();
        int magicNum = rnd.Next(1, 100); 
        string guess;
        int guessNum;
        int counter = 0;

        Console.WriteLine("Guess the magic number!");

        do
        {
            Console.WriteLine("What is your guess? ");
            guess = Console.ReadLine();
            guessNum = Convert.ToInt32(guess);
            counter++;

            if (magicNum > guessNum)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                Console.WriteLine("Lower.");
            }
        } while (magicNum != guessNum);

        Console.WriteLine("You guessed it!");
        Console.WriteLine("It took you " + counter + " times!");
        

    }
}