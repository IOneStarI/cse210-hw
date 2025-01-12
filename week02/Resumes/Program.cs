using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Qality assurans engeneer";
        job1._company = "Choice";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Integration Manager";
        job2._company = "Choice";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Vlad Didkovskiy";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}