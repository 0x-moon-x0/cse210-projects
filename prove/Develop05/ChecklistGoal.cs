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
            ShowConfetti(3);
            Console.WriteLine();

            DisplayCongratulations();

            Console.WriteLine();
            ShowConfetti(3);

            Console.WriteLine();
            Console.WriteLine($"You get a bonus {_bonus} points for completing this task!");
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

    public void DisplayCongratulations()
    {
        List<string> ascii = new List<string>
        {
            "  ____                 _       _       _     _ ",
            " / ___| ___   ___   __| |     | | ___ | |__ | |",
            "| |  _ / _ \\ / _ \\ / _` |  _  | |/ _ \\| '_ \\| |",
            "| |_| | (_) | (_) | (_| | | |_| | (_) | |_) |_|",
            " \\____|\\___/ \\___/ \\__,_|  \\___/ \\___/|_.__/(_)",
        };
        
        foreach (string a in ascii)
        {
            Console.WriteLine(a);
        }
    }

    public void ShowConfetti(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            List<string> animationStrings = new List<string>
            {
                "*     .       *       .       *       .     *",
                ".     *       .       *       .       *     ."
            };

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            }
        }
    }
}