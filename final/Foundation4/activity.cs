public class Activity
{
    protected string activityType;
    public double durationMinutes { get; protected set; }

    public Activity(string activityType, double durationMinutes)
    {
        this.activityType = activityType;
        this.durationMinutes = durationMinutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return $"Activity: {activityType}, Duration: {durationMinutes} minutes, Distance: {distance} Miles , Speed: {speed} mph, Pace: {pace} min per mile";
    }
}
