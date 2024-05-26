using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent(GoalManager manager)
    {
        manager.AddScore(_points);
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are eternal
    }

    public override string GetDetailsString()
    {
        return $"Name: {_shortName}, Description: {_description}, Points per event: {_points}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName}";
    }
}
