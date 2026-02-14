using System.Xml;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string Choice = Console.ReadLine();

        Console.WriteLine("Enter short name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points:");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        if (Choice == "1")
        {
            _goals.Add(new SimpleGoal(description, name, points));
        }

        if (Choice == "2")
        {
            _goals.Add(new EternalGoal(description, name, points));
        }

        if (Choice == "3")
        {
            Console.WriteLine("Enter target amount:");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter bonus points:");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(description, name, points, target, bonus));
        }   
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        ListGoalNames();

        Console.WriteLine("Select a goal to record :");
        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > _goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

        int earnedPoints = _goals[choice - 1].RecordEvent();
        _score += earnedPoints;
        Console.WriteLine($"You earned {earnedPoints} points!");
        Console.WriteLine($"Your total score is now {_score}.");



    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter filename to save goals:");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter filename to load:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(':');

            string goalType = parts[0];
            string[ ] data = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                bool isComplete = bool.Parse(data[3]);

                SimpleGoal goal = new SimpleGoal(description, name, points);

                if (isComplete)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }

            else if (goalType == "EternalGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);

                _goals.Add(new EternalGoal(description, name, points));
            }

            else if (goalType == "ChecklistGoal")
            {
                string name = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int target = int.Parse(data[3]);
                int amountCompleted = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);

                ChecklistGoal goal = new ChecklistGoal(description, name, points, target, bonus);
                goal.SetAmountCompleted(amountCompleted);

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    
}
