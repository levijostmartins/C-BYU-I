public class Cycling : Activity
{
    private double distanceKm;

    public Cycling(double durationMinutes, double distanceKm) : base("Cycling", durationMinutes)
    {
        this.distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return distanceKm;
    }

    public override double GetSpeed()
    {
        return (distanceKm / durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return durationMinutes / distanceKm;
    }
}
