public class Running : Activity
{
    private double distanceMiles;

    public Running(double durationMinutes, double distanceMiles) : base("Running", durationMinutes)
    {
        this.distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        return (distanceMiles / durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return durationMinutes / distanceMiles;
    }
}
