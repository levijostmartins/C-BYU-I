using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(GoalManager manager)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            manager.AddScore(_points);
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"Name: {_shortName}, Description: {_description}, Points: {_points}, Complete: {_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName} [{(_isComplete ? "X" : " ")}]";
    }
}
