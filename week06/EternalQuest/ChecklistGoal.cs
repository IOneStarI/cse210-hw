class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"Recorded event for '{_name}' ({_currentCount}/{_targetCount} completed). You earned {_points} points!");

        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Congratulations! You completed '{_name}' and earned an additional {_bonusPoints} bonus points!");
        }
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed {_currentCount}/{_targetCount} times";
    }
}
