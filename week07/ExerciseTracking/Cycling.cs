using System.Diagnostics;

public class Cycling : Activity
{
    private double _velocity;

    public Cycling(string name, int duration, string date, double velocity) : base(name, duration, date)
    {
        _velocity = velocity;
    }

    public override double Distance()
    {
        return (_velocity / 60) * GetDuration();
    }
    public override double Speed()
    {
        return _velocity;
    }
    public override double Pace()
    {
        return 60 / _velocity;
    }
}