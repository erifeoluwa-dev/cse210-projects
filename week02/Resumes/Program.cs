using System;

public class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "WebDesign";
        job1._startYear = 2025;
        job1._stopYear = 2027;
        
        Job job2 = new Job();
        job2._company = "Total Energy";
        job2._jobTitle = "Data Analysis";
        job2._startYear = 2026;
        job2._stopYear = 2027;
        
        Resume myResume = new Resume();
        myResume._name = "Ojelade Ifeoluwa";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

    }
}