//Entry class - complete
public class Entry
//class 2 to write
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        //this builds the string that will be returned here but displayed in the Program.cs
        return $"Date: {_date}/n"
        + $"Prompt: {_promptText}/n"
        + $"{_entryText}";
        // n/ makes a new line before it prints, 
        //no parenthesis needed here - you need the () around the string when you call it into a function like Console.WriteLine($"Print this line")
    }
}


