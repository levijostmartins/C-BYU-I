using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Start();
        var prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(5);

        var items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        var list = new List<string>();
        Console.WriteLine("Enter items (type 'done' when finished):");

        while (true)
        {
            var input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            list.Add(input);
        }
        return list;
    }
}
