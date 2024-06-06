using System;

public class Menu
{
    public static string DisplayMenuAndGetChoice()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Track an Activity");
        Console.WriteLine("2. Display All Tracked Activities");
        Console.WriteLine("Q. Quit");

        Console.Write("Please enter your choice: ");
        return Console.ReadLine().ToLower();
    }

    public static void TrackActivityMenu()
    {
        Console.WriteLine("\nSelect an activity to track:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Swimming");
        Console.WriteLine("3. Cycling");
        Console.Write("Enter your choice: ");
    }
}
