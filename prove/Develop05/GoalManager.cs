public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string userInput = "";

        while (userInput != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
            }

            else if (userInput == "2")
            {
                ListGoalDetails();
            }

            else if (userInput == "3")
            {
                SaveGoals();
            }

            else if (userInput == "4")
            {
                LoadGoals();
            }

            else if (userInput == "5")
            {
                RecordEvent();
            }

            else if (userInput == "6")
            {
                break;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please select a number from the menu.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int index = 1;

        Console.WriteLine();
        Console.WriteLine("The goals are:");
        Console.WriteLine();

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index += 1;
        }
    }

    public void ListGoalDetails()
    {
        int index = 1;

        Console.WriteLine();
        Console.WriteLine("The goals are:");
        Console.WriteLine();

        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{index}. [X] {goal.GetDetailsString()}");
                index += 1;
            }

            else
            {
                Console.WriteLine($"{index}. [ ] {goal.GetDetailsString()}");
                index += 1;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine();

        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();

        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.WriteLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.WriteLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (userInput == "1")
        {
            SimpleGoal simple = new SimpleGoal(name, description, points);
            _goals.Add(simple);
        }

        else if (userInput == "2")
        {
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
        }

        else if (userInput == "3")
        {
            Console.WriteLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklist);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.WriteLine();
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine()) - 1;

        _goals[userInput].RecordEvent();
        _score += _goals[userInput].GetPoints();

        Console.WriteLine();
        Console.WriteLine($"You now have {_score} points!");
    }

    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("Please enter filename (without file format): ");
        string filename = $"{Console.ReadLine()}.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine();
        Console.Write("Please enter filename (without file format): ");
        string filename = $"{Console.ReadLine()}.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|~|");

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completion = Convert.ToBoolean(parts[4]);

                SimpleGoal simple = new SimpleGoal(name, description, points);
                _goals.Add(simple);
            }

            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }

            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklist);
            }

            else
            {
                int score = int.Parse(parts[0]);
                _score = score;
            }
        }
    }
}