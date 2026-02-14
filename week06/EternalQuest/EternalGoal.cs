public class EternalGoal : Goal
{
    public EternalGoal(string description, string name, int points) : base(description, name, points)
    {
        
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetShortName()},{GetDescription()},{GetPoints()}";
    }
}