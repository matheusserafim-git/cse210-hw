public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string description, string name, int points) : base(description, name, points)
    {
        
    }

    public override int RecordEvent()
    {
       if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            return GetPoints();
        }
        else
        {
            Console.WriteLine("This goal is already compelted.");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}