class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding your breathing.") { }

    protected override void RunActivity()
    {
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);
            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
        }
    }
}