using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();

        job1.name = "Software Engineer";
        job1.company = "Microsoft";
        job1.startYear = 2019;
        job1.endYear = 2022;

        job1.Resume();


    }
}
 class Job{
  public string name;
  public string company;
  public int startYear; 
  public int endYear; 

   public void Resume()
  {
    Console.WriteLine($"{name} ({company}), {startYear}-{endYear}");
  }
}