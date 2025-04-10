
using System;
using System.Collections.Generic;
using System.IO; 

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

    public static void SaveJournal(Journal myJournal)
    {
        Console.WriteLine("Enter the name of the file you would like to save the journal to: ");
        string filename = Console.ReadLine();
        myJournal.SaveToFile(filename);
    }

    public static void LoadJournal(string filename)
    {
        try
        {
            Console.WriteLine($"\n--- {filename} Journal ---");
            string fileContent = File.ReadAllText(filename);
            Console.WriteLine(fileContent);
        }
        catch (Exception)
        {
            Console.WriteLine($"Error loading file. (try adding .txt)");
        }
}
}
