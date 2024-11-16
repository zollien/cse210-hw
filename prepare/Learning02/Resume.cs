using System;

//class Resume
public class Resume
{
    //variables
    public string _name;

    // this creates a new list for jobs to populate
    public List<Job> _jobs = new List<Job>();

    //
    public void Display()
    {
        //dislay job title and other info depending on class member variables created/specified
        // variable names start lowercase.
        //writing the name string needs $""
        Console.WriteLine($"Name: {_name}");
        //but writing the list just needs "" as not a string it is a list
        Console.WriteLine("Jobs:");

        //foreach (item in List<Job>) Job(list) job(_job) in _jobs(nameforlist)
        foreach (Job job in _jobs)
        {
            //call the display method for each job - iterate through each job instance
            job.Display();
        }
    }
}