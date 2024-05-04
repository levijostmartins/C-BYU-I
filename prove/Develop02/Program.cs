using System;
using System.Collections.Generic;
using System.IO;

class Program
{
     static void Main()
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveJournalToFile();
                    break;
                case "4":
                    journal.LoadJournalFromFile();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Daily Journal Entry System");
        Console.WriteLine("1- Write a new entry");
        Console.WriteLine("2- Display the journal");
        Console.WriteLine("3- Save the journal to a file");
        Console.WriteLine("4- Load the journal from a file");
        Console.WriteLine("5- Exit");
        Console.Write("Enter your choice (numbers only): ");
    }
}

