using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{

    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i< numberToHide && visibleWords.Count > 0 ; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    
    
    public bool IsCompletelyHidden(int numberToHide)
    {
        Random random = new Random ();
        List<Word> visibleWords = _words.Where (w => !w.IsHidden()).ToList();
        for (int i = 0; i > numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
        return _words.All (w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n";
        
        foreach (Word word in _words)
        {
            text += word.GetDisplayText()+" ";
        }
        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    // Improve the program

    public int VisibleWordCount()
    {
        int count = 0;
         foreach(Word word in _words)
         {
            if (!word.IsHidden())
            {
                count++;          
            }
        }

        return count;
    }
}