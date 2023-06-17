using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    
    static void Main(string[] args)
   {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices.");
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Journal j1 = new Journal();
        j1._Write = "Write";
        Console.Write("Who was the most interesting person I interacted with today? ");
        Console.Write("What was the best part of my day? ");
        Console.Write("How did I see the hand of the Lord in my life today? ");
        Console.Write("What was the strongest emotion I felt today? ");
        Console.Write("If I had one thing I could do over today, what would it be? ");

        Journal j2 = new Journal();
        j2._Display = "Display";

        Journal j3 = new Journal();
        j3._Load = "Load";

        Journal j4 = new Journal();
        j4._Save = "Save";

        Journal j5 = new Journal();
        j5._Quit = "Quit";

        List<Journal> journal = new List<Journal>();
        journal.Add(j1);
        journal.Add(j2);
        journal.Add(j3);
        journal.Add(j4);
        journal.Add(j5);

        foreach (Journal j in journal)
        {
            Console.WriteLine(j1._Write);

            //Console.WriteLine(j2._Display);  
        }
        SaveToFile(journal);

        List<Journal> newJournal = ReadFromFile();
        foreach (Journal j in newJournal)
        {
            Console.WriteLine(j._Write);
        }
    }
    public static void SaveToFile(List<Journal> journal)    
    {
        Console.WriteLine("Saving to file...");

        string filename = "journal.txt";

        using(StreamWriter outputFile = new StreamWriter(filename) )
    {
        foreach (Journal j in journal)
        {
            outputFile.WriteLine($"{j._Write}~{j._Display}~{j._Load}~{j._Save}~{j._Quit}");
        }
    }

    }

    public static List<Journal>ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Journal> journal = new List<Journal>();
        string filename = "journal.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine();
            string[] parts = line.Split("~");

            //parts[0] - Write
            //parts[1] - Display
            //parts[2] - Load
            //parts[3] - Save
            //parts[4] - Quit

            Journal newJournal = new Journal();
            newJournal._Write = parts[0];
            newJournal._Display = parts[1];
            newJournal._Load = parts[2];
            newJournal._Save = parts[3];
            newJournal._Quit = parts[4];

            journal.Add(newJournal);
        }

        return journal;
    }

}