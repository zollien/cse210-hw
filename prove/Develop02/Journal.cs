using System.IO;
public class Journal
{
    //class3 to write - 50% ? INCOMPLETE
    public List<Entry> _entries = new List<Entry>(); //calls the constructor of the class and initialises it

    public PromptGenerator _promptgen = new PromptGenerator();

    public void AddEntry() //paremeters are not needed inside AddEntry(Entry entry)
    {
        Entry entry = new Entry(); //this is a constructor covered in w04 info
        entry._date = DateTime.Now.ToShortDateString();

        //prompt text added from PromptGenerator
        entry._promptText = _promptgen.GetRandomPrompt();  //to execute prompt gen
        Console.WriteLine($"{entry._promptText}");
        //entry text added from User input
        entry._entryText = Console.ReadLine();
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());

        }
    }
    public void SaveToFile(string file)
    {
        //code from assignment

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}\n");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);

        }
    }

}
