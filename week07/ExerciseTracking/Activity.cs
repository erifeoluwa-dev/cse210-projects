public abstract class Activity
{
    private DateTime _date;
    private int _minutes;
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetActivityName()} ({_minutes} min): " +
            $"Distance {GetDistance():0.0} miles, " +
            $"Speed {GetSpeed():0.0} mph, " +
            $"Pace: {GetPace():0.0} min per mile";
    }

    public virtual string GetActivityName()
    {
        return "Activity";
    }
}