using System;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> listOfNum = new List<int>();
        int numOfUser = -1;

        //Prompt user for input
        Console.WriteLine("Please enter a series of numbers, type '0' when finished: ");

        // Add numbers that aren't 0 to list
        while (numOfUser != 0)
        {
            Console.WriteLine("Enter number: ");
            string inputNum = Console.ReadLine();
            numOfUser = int.Parse(inputNum); 
            

            if (numOfUser != 0)
            {
                listOfNum.Add(numOfUser);
            }
        }

        Console.WriteLine("This is the count of numbers in this list: " + listOfNum.Count);

        Console.WriteLine("This is each number in the list: ");
        foreach (int numbers in listOfNum)
        {
            Console.WriteLine(numbers);
        }

        int totalSum = 0;
        foreach (int numbers in listOfNum)
        {
            totalSum += numbers;
        }
        Console.WriteLine($"This is the total sum of all the numbers: {totalSum}");

        int largestNum = 0;
        foreach (int numbers in listOfNum)
        {
            if (largestNum < numbers)
            {
                largestNum = numbers;
            }
        }
        Console.Write($"Largest number is: {largestNum}");
        


    }
}