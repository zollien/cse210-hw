using System;
/*using system call teh system name space*/
/*"namepaces game" the there is ususally a namesspace which like a package that can be referenced game would be the name of the package */
class Program /*the class program is the shell that contains the program*/
{
    
    static void Main(string[] args) 
    
    {
        //create new jobs here, each job with its own instance id, job1, job2 etc

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

        //Resume class to create new Resume for each named person
        Resume myResume = new Resume();
        myResume._name = "Zollien Dove";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //DISPLAY RESUME
        myResume.Display();
    }
}