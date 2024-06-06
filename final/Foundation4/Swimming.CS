public class Swimming : Activity
{
    private int laps;

    public Swimming(double durationMinutes, int laps) : base("Swimming", durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        double distanceKm = laps * 50 / 1000.0;
        double distanceMiles = distanceKm * 0.62;
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return durationMinutes / GetDistance();
    }
}
