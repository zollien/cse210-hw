using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>(); //calls the list contructor for the Entry class. _entries variable for the Entry class list that will be created
    public PromptGenerator _promptgen = new PromptGenerator(); //links Journal to PromptGenerator.cs

    //OPTION 1 Write - WORKING
    public void AddEntry() //no parameters needed inside 
    {
        Entry entry = new Entry(); //Entry() constructor
        entry._date = DateTime.Now.ToShortDateString(); //calls date time now
        entry._promptText = _promptgen.GetRandomPrompt(); //calls promptgenerator and gets a prompt 
        Console.WriteLine($"{entry._promptText}");
        entry._entryText = Console.ReadLine(); //reads entry text entered by user
        _entries.Add(entry);  //appends to List<Entry>
    }
    //OPTION 2 Display - WORKING
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    //OPTION 3 Load from File
    public List<Entry> LoadFromFile(string file) //connects to cvs or file. parameters needed to load from file
    {

        string[] lines = System.IO.File.ReadAllLines(file);

        List<Entry> newEntries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            newEntries.Add(entry);
        }

        return newEntries; // to return the entries in the journal
    }
    // OPTION 4 Save to File
    public void SaveToFile(List<Entry> entries, string file) //paramenters needed to save to file, void because theer is nothing to return

    {
        using (StreamWriter outputFile = new StreamWriter(file)) //opens the file and closes it when written.

            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }

    }
}