using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input a number between 0-100: ");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);

        if (grade >= 90)
        {
            Console.Write("Grade is an A");
        }
        else if (grade >= 80)
        {
            Console.Write("Grade is an B");
        }
        else if (grade >= 70)
        {
            Console.Write("Grade is an C");
        }
        else if (grade >= 60)
        {
            Console.Write("Grade is an D");
        }
        else if (grade < 60)
        {
            Console.Write("Grade is an F");
        }

        int gradeRemainder = grade % 10;
        if (gradeRemainder >= 7)
        {
           if (grade < 90)
           {
                if (grade > 60)
                {
                    Console.WriteLine("+.");
                }
                else
                {
                    Console.WriteLine(".");
                }
           }
           else
           {
                Console.WriteLine(".");
           }
        }
        else if (gradeRemainder < 3)
        {
            if (grade > 60)
            {
                Console.WriteLine("-.");
            }
            else
            {
                Console.WriteLine(".");
            }
        }
        else
        {
            Console.WriteLine(".");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass!");
        }
        
    }
}

