using System;
/* Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs.
*/

public class Resume /*the class program is the shell that contains teh program*/
{
    //variables
    public string _name;

    //creates new list for jobs to populate
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        //display job title etc
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        //for each item in List<Job> the job list, iterare through each job instance and display each job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}