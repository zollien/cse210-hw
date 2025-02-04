using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string Display() //builds a string that will return here, called and displayed by Program.cs 
    {
        return $"Date: {_date} \n" // \n new line
        + $"Prompt: {_promptText} \n"
        + $"Entry: {_entryText}";
    }
}