using System;
using System.Collections.Generic;


public class ScriptureList
{
    
    private List<string> scriptures;

    
    public ScriptureList(params string[] initialScriptures)
    {
        scriptures = new List<string>(initialScriptures);
    }

    
    public void AddScripture(string scripture)
    {
        scriptures.Add(scripture);
    }

    
    public void RemoveScripture(string scripture)
    {
        scriptures.Remove(scripture);
    }

    
    public void ClearScriptures()
    {
        scriptures.Clear();
    }

    
    public void ShowScriptures()
    {
        Console.WriteLine("The scripture list contains:");
        foreach (string scripture in scriptures)
        {
            Console.WriteLine(scripture);
        }
    }
}

      

