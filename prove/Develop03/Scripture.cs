using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    private List<int> _hiddenWordIndices;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
        _hiddenWordIndices = new List<int>();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(_words.Count);
            } while (_hiddenWordIndices.Contains(index));

            _words[index].Hide();
            _hiddenWordIndices.Add(index);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = $"{_reference.GetDisplayText()}\n";

        foreach (var word in _words)
        {
            scriptureText += $"{word.GetDisplayText()} ";
        }

        return scriptureText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _hiddenWordIndices.Count == _words.Count;
    }
}
