public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / GetDuration()) / 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetDuration() / GetDistance(), 2);
    }
}