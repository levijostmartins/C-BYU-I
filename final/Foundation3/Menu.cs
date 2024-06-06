using System;
using System.Collections.Generic;
using System.Threading;

public class Menu
{
    private List<Event> _events;
    private Dictionary<int, string> _eventNames;

    public Menu(List<Event> events)
    {
        _events = events;
        _eventNames = new Dictionary<int, string>();

        for (int i = 0; i < _events.Count; i++)
        {
            _eventNames.Add(i + 1, _events[i].Title);
        }
    }

    public void DisplayEvents()
    {
        Console.Clear();
        Console.WriteLine("Events:");
        foreach (var name in _eventNames)
        {
            Console.WriteLine($"{name.Key}. {name.Value}");
        }
    }

    public void ChooseEvent()
    {
        while (true)
        {
            DisplayEvents();

            Console.WriteLine("\nEnter the number of the event you want to view, or 'q' to quit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
                break;

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= _eventNames.Count)
            {
                DisplayEventOptions(choice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid event number.");
            }
        }
    }

    private void DisplayEventOptions(int index)
    {
        Console.Clear();
        Console.WriteLine($"Event: {_eventNames[index]}");
        Console.WriteLine("Choose the level of detail:");
        Console.WriteLine("1. Short Description");
        Console.WriteLine("2. Full Details");
        Console.WriteLine("3. Standard Details");
        Console.Write("Enter your choice: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 3)
        {
            DisplayLoadingAnimation();
            DisplayEventDetails(index, choice);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        }
    }

    private void DisplayLoadingAnimation()
    {
        Console.Write("\nLoading");
        char[] spinChars = { '/', '-', '\\', '|' };
        for (int i = 0; i < 12; i++)
        {
            Console.Write(spinChars[i % 4]);
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine();
    }

    private void DisplayEventDetails(int index, int choice)
    {
        Console.Clear();
        Console.WriteLine($"Event: {_eventNames[index]}");
        Console.WriteLine("Details:");
        Console.WriteLine("----------------------------------------------------");
        

        switch (choice)
        {
            case 1:
                Console.WriteLine(_events[index - 1].GetShortDescription());
                break;
            case 2:
                Console.WriteLine(_events[index - 1].GetFullDetails());
                break;
            case 3:
                Console.WriteLine(_events[index - 1].GetStandardDetails());
                break;
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
