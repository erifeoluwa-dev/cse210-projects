using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = new DateTime(2026, 10, 12);

        Running running = new Running(date, 30, 3.0);
        Cycling cycling = new Cycling(date, 30, 15.0);
        Swimming swimming = new Swimming(date, 30, 20);

        List<Activity> activities = new List<Activity>();

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}