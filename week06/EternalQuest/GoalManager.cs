class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoal(string goalName)
    {
        Goal goal = _goals.FirstOrDefault(g => g.GetDetailsString().Contains(goalName));
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.GetPoints();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Score: {_score}");
    }
}
