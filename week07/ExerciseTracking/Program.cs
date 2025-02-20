using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running(new DateTime(2022, 11, 3), 30, 3.0); // 30 min, 3 miles
        Cycling bike = new Cycling(new DateTime(2022, 11, 3), 30, 12.0); // 30 min, 12 mph
        Swimming swim = new Swimming(new DateTime(2022, 11, 3), 30, 20); // 30 min, 20 laps

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
