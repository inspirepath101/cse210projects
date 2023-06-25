using System;
using System.Collections.Generic;
using System.IO;

 
class Program
{
    static Journal journal = new Journal();

 
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;
                case "2":
                    DeleteEntry();
                    break;
                case "3":
                    DisplayEntries();
                    break;
                case "4":
                    SaveJournal();
                    break;
                case "5":
                    LoadJournal();
                    break;
                case "6":
                    return;
            }
        }
    }

 
    static void DisplayMenu()
    {
        Console.WriteLine("1. Add entry");
        Console.WriteLine("2. Delete entry");
        Console.WriteLine("3. Display entries");
        Console.WriteLine("4. Save journal");
        Console.WriteLine("5. Load journal");
        Console.WriteLine("6. Exit");
    }

 
    static void AddEntry()
    {
        Console.Write("Enter date (MM/DD/YYYY): ");
        string date = Console.ReadLine();
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        journal.AddEntry(date, text);
    }

 
    static void DeleteEntry()
    {
        Console.Write("Enter entry number to delete: ");
        int index = int.Parse(Console.ReadLine());
        journal.DeleteEntry(index);
    }

 
    static void DisplayEntries()
    {
        journal.DisplayEntries();
    }

 
    static void SaveJournal()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        FileManager.SaveJournal(journal, filename);
    }

 
    static void LoadJournal()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        journal = FileManager.LoadJournal(filename);
    }
}
