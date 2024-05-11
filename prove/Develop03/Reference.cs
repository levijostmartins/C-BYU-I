using System;

class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int Verse { get; private set; }
    public int EndVerse { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public static Reference FromCSV(string csvLine)
    {
        string[] values = csvLine.Split(',');

        string book = values[0].Trim();
        int chapter = int.Parse(values[1].Trim());
        int verse = int.Parse(values[2].Trim());
        int endVerse = values.Length > 3 && !string.IsNullOrEmpty(values[3].Trim()) ? int.Parse(values[3].Trim()) : 0;

        return new Reference(book, chapter, verse, endVerse);
    }

    public string GetDisplayText()
    {
        if (EndVerse == 0)
        {
            return $"{Book} {Chapter}:{Verse}";
        }
        else
        {
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
        }
    }
}
