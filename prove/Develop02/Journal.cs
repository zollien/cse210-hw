using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>(); //calls the list contructor for the Entry class. _entries variable for the Entry class list that will be created
    public PromptGenerator _promptgen = new PromptGenerator(); //links Journal to PromptGenerator.cs

    //OPTION1Code    
    public void AddEntry() //no parameters needed inside 
    {
        Entry entry = new Entry(); //Entry() constructor
        entry._date = DateTime.Now.ToShortDateString(); //calls date time now
        entry._promptText = _promptgen.GetRandomPrompt(); //calls promptgenerator and gets a prompt 
        Console.WriteLine($"{entry._promptText}");
        entry._entryText = Console.ReadLine(); //reads entry text entered by user
        _entries.Add(entry);  //appends to List<Entry>
    }
    //OPTION2Code
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }
    //OPTION 3 Code
    public void LoadFromFile(string file) //connects to cvs or file. parameters needed to load from file
    {
        _entries.Clear(); //clears previous entry
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(" | ");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry); //appends to file
        }
    }
    // OPTION 4 Code
    public void SaveToFile(string file) //paramenters needed to save to file
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }
}