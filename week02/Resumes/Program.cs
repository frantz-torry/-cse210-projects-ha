using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job ();
        job1._jobTitle = "Software Engineer";
        job1._company ="Microsoft";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";

        Resume myResume = new Resume();
        myResume._name = "Jack Sparrow";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}