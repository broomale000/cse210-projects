
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
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found! Make sure the file exists.");
            return;
        }

        try
        {
            Console.WriteLine($"\n--- Loading Journal from {filename} ---");
            string fileContent = File.ReadAllText(filename);
            Console.WriteLine(fileContent);
            Console.WriteLine("\n--- End of Journal ---");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
}
}
