public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        Console.WriteLine($"Congrats! You earned {GetPoints()} points!");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congrats! You get a bonus {_bonus} points for completing this task!");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted != _target)
        {
            return false;
        }
        
        else
        {
            return true;
        }
    }

    public override string GetDetailsString()
    {
        return $"{GetName()} ({GetDescription()}) -- Progress: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|~|{GetName()}|~|{GetDescription()}|~|{GetPoints()}|~|{_bonus}|~|{_target}|~|{_amountCompleted}";
    }
}