using System.Diagnostics;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string name, int duration, string date, double laps) : base("Swimming", duration, date)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        if (_duration ==0) return 0;
         return _laps * 50/1000; // Convert laps to kilometers (50 meters per lap)
    }

    public override double Speed()
    {
        return (Distance() / GetDuration()) * 60;
    }
    public override double Pace()
    {
        return (GetDuration() / Distance());
    }
}