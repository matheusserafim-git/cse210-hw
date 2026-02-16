using System.Diagnostics.CodeAnalysis;

public abstract class Activity
{
    private string _name;
    protected int _duration;
    private string _date;

    public Activity(string name, int duration, string date)
    {
        _name = name;
        _duration = duration;
        _date = date;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();
    public string GetSummary()
    {
        return $"{_date} - {_name} ({_duration} min) - Distance: {Distance()} km, Speed: {Speed()} Km/h, Pace: {Pace()} min per km";
    }
}