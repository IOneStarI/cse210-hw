    abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_activityName}...");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        RunActivity();
        EndActivity();
    }

    protected abstract void RunActivity();

    protected void EndActivity()
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You completed {_activityName} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}