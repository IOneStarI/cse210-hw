using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var wordsToHide = _words.Where(word => !word.IsHidden()).OrderBy(_ => Guid.NewGuid()).Take(count).ToList();

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string GetDisplayText()
    {
        var scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference}\n{scriptureText}";
    }
}
