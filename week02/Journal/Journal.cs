using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{   
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>() 
    { "Who was the most interesting person I interacted with today?", "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };

    public void WriteNewEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string chosenPrompt = _prompts[index];
        Console.Write(chosenPrompt + " ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        Entry entry1 = new Entry();
        entry1._prompt = chosenPrompt;
        entry1._response = response;
        entry1._date = date;
        _entries.Add(entry1);



    }
    public void Display()
    {
        
        foreach (Entry e in _entries)
            {
                e.Display();
            }
    }

    public void SaveToFile()
    {
        Console.Write("What is the filename (e.g. journal.txt)? ");
        string filename = Console.ReadLine();
        List<string> lines = new List<string>();

        foreach (Entry e in _entries)
            {
                lines.Add(e.GetSaveString());
            }
        File.WriteAllLines(filename, lines);
    }
    public void LoadFromFile()
    {
        Console.Write("What is the filename (e.g. journal.txt)? ");
        string filename = Console.ReadLine();
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
            {
                string[] parts = line.Split('~');
                Entry entry = new Entry();
                entry._prompt = parts[0];
                entry._response = parts[1];
                entry._date = parts[2];
                _entries.Add(entry);
            }
        
    }
    // Enhancement: Users can add their own custom journal prompts to the
    // rotation, addressing the "I don't know what to write about" barrier
    // mentioned in the assignment by letting them personalize their prompts.
    public void AddCustomPrompt()
    {
        Console.Write("Enter your custom prompt: ");
        string customPrompt = Console.ReadLine();
        _prompts.Add(customPrompt);
    }
}
