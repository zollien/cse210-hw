using System;

class Program
{
    //creating an instance to connect to job.cs 
    static void Main(string[] args)
    {
        // create new jobs here, each woth own instance id, job1, job2 etc using job1.variable
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //new myResume class to create new resumes for each new nameperson using myResume.variable
        Resume myResume = new Resume();
        myResume._name = "Zollien Dove";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Display Resume
        myResume.Display();
    }
}