using System;
/* 
Responsibilities:
Keeps track of the company, job title, start year, and end year.
Behaviors:
Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".*/
public class Job /*the class JOB is a public class*/
{
    //class member variables go here, dont add strings here - link to same variables in Program.cs
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //instance - 
    public void Display() 
    {
        //display job details: title, company, start/end year
        //variable names start lowercase
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
    }
}