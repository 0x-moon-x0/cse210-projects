public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round(_speed * (GetDuration() / 60), 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}