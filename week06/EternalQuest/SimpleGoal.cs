class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_name}' completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
        }
    }
}
