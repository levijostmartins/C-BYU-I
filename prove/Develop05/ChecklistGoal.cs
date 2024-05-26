using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent(GoalManager manager)
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            manager.AddScore(_points);

            if (_amountCompleted == _target)
            {
                manager.AddScore(_bonus);
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"Name: {_shortName}, Description: {_description}, Points: {_points}, Target: {_target}, Completed: {_amountCompleted}, Bonus: {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName} [{_amountCompleted}/{_target}]";
    }
}
