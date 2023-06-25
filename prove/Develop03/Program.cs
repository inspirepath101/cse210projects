using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        ScriptureList scriptureList = new ScriptureList(
            "D&C 59:3",
            "D&C 64:34",
            "D&C 93:1",
            "D&C 89:18"
        );

        
        scriptureList.ShowScriptures();

        
        scriptureList.AddScripture("Alma 3:26-27");

        
        scriptureList.ShowScriptures();

        
        scriptureList.RemoveScripture("D&C 93:1");

        
        scriptureList.ShowScriptures();

        
        scriptureList.ClearScriptures();

        
        scriptureList.ShowScriptures();
    }
    
}