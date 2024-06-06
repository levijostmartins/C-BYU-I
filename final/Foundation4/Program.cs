using System;
using System.Collections.Generic;

class Program
{
    static List<Activity> activities = new List<Activity>();

    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            string choice = Menu.DisplayMenuAndGetChoice();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    TrackActivity();
                    break;
                case "2":
                    Console.Clear();
                    DisplayTrackedActivities();
                    break;
                case "q":
                    isRunning = false;
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void TrackActivity()
    {
        Menu.TrackActivityMenu();
        string activityChoice = Console.ReadLine();

        switch (activityChoice)
        {
            case "1":
                TrackRunning();
                break;
            case "2":
                TrackSwimming();
                break;
            case "3":
                TrackCycling();
                break;
            default:
                Console.WriteLine("Invalid choice! Please try again.");
                break;
        }
    }

    static void TrackRunning()
    {
        Console.Write("Enter duration in minutes: ");
        double duration = double.Parse(Console.ReadLine());
        Console.Write("Enter distance in miles: ");
        double distance = double.Parse(Console.ReadLine());

        activities.Add(new Running(duration, distance));
        Console.WriteLine("Running activity tracked successfully!");
    }

    static void TrackSwimming()
    {
        Console.Write("Enter duration in minutes: ");
        double duration = double.Parse(Console.ReadLine());
        Console.Write("Enter number of laps: ");
        int laps = int.Parse(Console.ReadLine());

        activities.Add(new Swimming(duration, laps));
        Console.WriteLine("Swimming activity tracked successfully!");
    }

    static void TrackCycling()
    {
        Console.Write("Enter duration in minutes: ");
        double duration = double.Parse(Console.ReadLine());
        Console.Write("Enter distance in kilometers: ");
        double distance = double.Parse(Console.ReadLine());

        activities.Add(new Cycling(duration, distance));
        Console.WriteLine("Cycling activity tracked successfully!");
    }

static void DisplayTrackedActivities()
{
    if (activities.Count == 0)
    {
        Console.WriteLine("No activities tracked yet.");
        return;
    }

    Console.WriteLine("\nTracked Activities:");
    foreach (var activity in activities)
    {
        string units = activity is Running ? "miles" : activity is Cycling ? "kilometers" : "laps";
        double distance = activity.GetDistance();
        double speed = activity.GetSpeed();
        double pace = activity.GetPace();

        Console.WriteLine($"{activity.GetSummary()} " +
                          $"(Time: {activity.durationMinutes} minutes, " +
                          $"Speed: {speed:F2} {units}/hour, " +
                          $"Pace: {pace:F2} minutes/{units})");
    }
}

}
