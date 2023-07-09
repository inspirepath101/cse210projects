using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        List<Goal> goal = new List<Goal>();

        SimpleGoals g1 = new SimpleGoals("");
        goal.Add(g1);

        CheckListGoals g2 = new CheckListGoals("");
        goal.Add(g2);

        EternalGoals g3 = new EternalGoals("");
        goal.Add(g3)

        foreach (Goal g in goals)
        {
            string goal = g.GetGoal();

            Console.WriteLine($"")
        }


    }
    
}