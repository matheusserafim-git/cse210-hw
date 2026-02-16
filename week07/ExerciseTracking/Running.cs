public class Running : Activity
{
    private double _distance;

    public Running(string name, int duration, string date, double distance) : base(name, duration, date)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return (_distance / base._duration) * 60;
    }

    public override double Pace()
    {
        return (base._duration / _distance);
    }
}