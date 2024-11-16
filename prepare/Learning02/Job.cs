using System;

public class Job
{
    //class member variables go here (dot add string info here)
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //there are "instances were you print specific things
    public void Display()
    {
        //dislay job title and other info depending on class member variables created/specified
        // variable names start lowercase.
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

