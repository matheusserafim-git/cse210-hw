public abstract class Goal
{
    private string _description;
    private string _shortName;
    private int _points;

    public Goal(string description, string name, int points)
    {
        _description = description;
        _shortName = name;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();
    
    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "Completed [X]" : "Incomplete [ ]";
        return $"{status} - {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}