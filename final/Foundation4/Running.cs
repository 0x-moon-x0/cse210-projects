public class Running : Activity
{
    private double _distance;

    public Running(string date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / GetDuration()) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetDuration() / _distance, 2); 
    }
}