using System.IO;
public class Journal
{
    //class3 to write - 50% ? INCOMPLETE
    public List<Entry> _entries;

    public void AddEntry() //paremeters are not needed inside AddEntry(Entry entry)
    {
        Entry entry = new Entry(); //this is a constructor covered in w04 info
        entry._date = DateOnly
        _entries

        //entry date added from DateTime.Now in Journal
        entry _date
        {
            //code from assignment
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString()
        }

        //prompt text added fro PromptGenerator
        entry _promptText
        {

        }

        //entry text added from User input
        entry _entryText
        {
            //code from assignment
            string fileName = "myFile.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");

                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
                //this looks like it prints to an outputFile to write the line
            }
        }
    }
    public void DisplayAll()
    {

    }
    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {

    }

}
