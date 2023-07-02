using System;
public class Activity
{
    static void activity(string[] args)
    {
        for (int i = 5; i > 0; i --)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine(".");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
        Console.WriteLine("Done");
    }
}

