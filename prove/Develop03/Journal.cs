
using System;
using System.Linq.Expressions;

public class Journal
{

    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry}\n\n");
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename, append: true))
            {
                foreach (var entry in entries)
                {
                    outputFile.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n-----------------------------------------------");
                }
                Console.WriteLine($"Journal saved to {filename}.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"Error writing to {filename}.");
        }
    }

    public void LoadFromFile()
    {
        
    }
}