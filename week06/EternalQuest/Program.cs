using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        manager.AddGoal(new SimpleGoal("Run a Marathon", "Complete a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read Scriptures", "Read daily scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Attend Temple", "Go 10 times", 50, 10, 500));

        manager.DisplayGoals();

        manager.RecordGoal("Read Scriptures");
        manager.RecordGoal("Attend Temple");
        manager.RecordGoal("Run a Marathon");

        manager.DisplayGoals();
    }
}
