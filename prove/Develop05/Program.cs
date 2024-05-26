using System;

public class Program
{
    public static void Main()
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record completed goal");
            Console.WriteLine("3. Display player info");
            Console.WriteLine("4. List goal names");
            Console.WriteLine("5. List goal details");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;
                case "2":
                    RecordEvent(goalManager);
                    break;
                case "3":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "4":
                    goalManager.ListGoalNames();
                    break;
                case "5":
                    goalManager.ListGoalDetails();
                    break;
                case "6":
                    goalManager.SaveGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private static void CreateGoal(GoalManager goalManager)
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type: ");
        string goalType = Console.ReadLine();

        Goal goal = goalType switch
        {
            "1" => new SimpleGoal(name, description, points),
            "2" => new EternalGoal(name, description, points),
            "3" => CreateChecklistGoal(name, description, points),
            _ => throw new InvalidOperationException("Invalid goal type.")
        };

        goalManager.CreateGoal(goal);
    }

    private static ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Enter target count: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points: ");
        int bonus = int.Parse(Console.ReadLine());
        return new ChecklistGoal(name, description, points, target, bonus);
    }

    private static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter goal name to record event: ");
        string name = Console.ReadLine();
        goalManager.RecordEvent(name);
    }
}
