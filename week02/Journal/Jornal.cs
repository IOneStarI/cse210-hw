using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private static Random _random = new Random();

    private List<string> _prompts = new List<string>
    {
        "What is one small moment or detail from today that I want to remember forever?",
        "How did I overcome a challenge or obstacle today?",
        "What is one thing I accomplished today that I feel proud of?",
        "What is something I feel grateful for today, and why?",
        "What made me smile or laugh today?"
    };

    public void AddEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Date,Prompt,Response");
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear();
            var lines = File.ReadAllLines(fileName);
            for (int i = 1; i < lines.Length; i++)
            {
                _entries.Add(Entry.FromCsv(lines[i]));
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}