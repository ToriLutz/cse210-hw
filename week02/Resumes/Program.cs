using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();


        
        job1.title = "Software Engineer";
        job1.company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

       Job job2 = new Job();
       

       job2.title = "Manager";
       job2.company = "Apple";
       job2.startYear = 2022;
       job2.endYear = 2023;

       Resume myResume = new Resume();
       myResume._name = "Allison Rose";
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

        myResume.Display(); 


    }
}
 
class Job
{
    public string title;
    public string company;
    public int startYear;
    public int endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"{title} ({company}) {startYear}-{endYear}");
    }
}

class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();  
        }
    }
}