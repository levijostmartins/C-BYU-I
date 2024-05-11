using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] scriptures = File.ReadAllLines("quad.csv");

        Random random = new Random();
        string selectedScripture = scriptures[random.Next(scriptures.Length)];

        string[] parts = selectedScripture.Split(',');
        string book = parts[0].Trim();
        int chapter = int.Parse(parts[1].Trim());
        int startVerse = int.Parse(parts[2].Trim());
        int endVerse = parts.Length > 3 && !string.IsNullOrEmpty(parts[3].Trim()) ? int.Parse(parts[3].Trim()) : 0;
        string text = string.Join(",", parts[4..]).Trim();

        Scripture scripture = new Scripture(new Reference(book, chapter, startVerse, endVerse), text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(1);
        }

        Console.Clear();
        Console.WriteLine("All words in the scripture are hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}
