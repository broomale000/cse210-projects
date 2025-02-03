using System;
using System.Collections.Generic;

public class Manager
{
    static List<string> prompts = new List<string>()
    {
        "What was the best part of your day?",
        "How did you feel today?",
        "What did you learn today?"
    };

    public static void WriteNewEntry(Journal journal)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)]; //Randomly generates an index based of the count of propmts

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();


        Entry newEntry = new Entry(prompt, response);
        journal.AddEntry(newEntry);

        Console.WriteLine("Entry saved!\n");
    }

    public static void SaveJournal()
    {

    }

    public static void LoadJournal()
    {

    }
}
