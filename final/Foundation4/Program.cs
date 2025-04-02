using System;

class Program
{
    static void Main(string[] args)
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km


        Console.WriteLine("Running:");
        Running Running1 = new Running("03 Nov 2022", 30, 4.8);
        Running1.CalculateSpeed();
        Running1.CalculatePace();
        Running1.Distance();
        Running1.GetSummary();

        Console.WriteLine("----------------------------------------------------");

        Console.WriteLine("Cycling:");
        Cycling Cycling1 = new Cycling("04 Sep 2025", 30, 19.2);
        Cycling1.CalculateSpeed();
        Cycling1.CalculatePace();
        Cycling1.Distance();
        Cycling1.GetSummary();

        Console.WriteLine("----------------------------------------------------");

        Console.WriteLine("Swimming:");
        Swimming Swimming1 = new Swimming("21 Jan 2019", 30, 5);
        Swimming1.CalculateSpeed();
        Swimming1.CalculatePace();
        Swimming1.Distance();
        Swimming1.GetSummary();

    }
}