using System;


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
            Console.WriteLine($"entry\n\n");
        }
    }

    public void SaveToFile()
    {
        
    }

    public void LoadFromFile()
    {
        
    }
}