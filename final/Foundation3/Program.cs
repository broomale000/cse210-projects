using System;

class Program
{
    static void Main(string[] args)
    {
        Address LectureAddress = new Address("15739 Hallway Boulevard");
        Lecture ElderLecture = new Lecture("Lecture", "How To Acquire Spiritual Knowledge", "A talk about revelation.", "November 1st 2025", "1:00 PM", "Elder Elder", 300, LectureAddress);
        ElderLecture.PrintStandardDetails();
        Console.WriteLine("--------------------------");
        ElderLecture.PrintShortDescription();
        Console.WriteLine("--------------------------");
        ElderLecture.PrintFullDetails();

        Console.WriteLine("\n\n");
        
        Address ReceptionAddress = new Address("10101 Binary Street");
        Reception WeddingReception = new Reception("Reception", "Wedding Reception", "A reception for a wedding.", "April 1st 2025", "5:00 PM", "wowmomwow@gmail.com", ReceptionAddress);
        WeddingReception.PrintStandardDetails();
        Console.WriteLine("--------------------------");
        WeddingReception.PrintShortDescription();
        Console.WriteLine("--------------------------");
        WeddingReception.PrintFullDetails();
    }
}