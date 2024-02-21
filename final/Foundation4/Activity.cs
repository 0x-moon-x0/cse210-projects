using System.Net.Mail;

public abstract class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int durationInMinutes)
    {
        _date = date;
        _duration = durationInMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"\n{_date} {GetType().Name} ({_duration} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }

    public int GetDuration()
    {
        return _duration;
    }
}