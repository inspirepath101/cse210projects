public class GoalManager
{
    public void Start()
    {

    int userInput1 = 0;
    while (userInterput1 !=6)
    {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options");
        Console.WriteLine(" 1.Create New Goal");
        Console.WriteLine(" 2.List Goals");
        Console.WriteLine(" 3.Save Goals");
        Console.WriteLine(" 4.Load Goals");
        Console.WriteLine(" 5.Record Event");
        Console.WriteLine(" 6.Quit");
        Console.Write("select a choice from the menu ");
        string userChoice1 = Console.ReadLine();
        userInput1 = int.Parse(userChoice1);
        if (userInput1 ==1)
        {
            Console.WriteLine("The types of goals are");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 1. Eternal Goal");
            Console.WriteLine(" 1. Checklist Goal");
            Console.Write("Which type of goal would you like to create?");
            string userChoice2 = Console.ReadLine();
            int userInput2 = int.Parse(userChoice2);
        } else if (userInput1 ==2) {
            ListGoalDetails();
        } else if (userInput1 ==3) {
            SaveGoals();
        } else if (userInput1 ==4) {
            LoadGoals();
        } else if (userInput1 ==5) {
            RecordEvent();  
        } else if (userInput1 ==6) {
            Console.WriteLine("That's it!");
            break;
        }
    }

}

}

