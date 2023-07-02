using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        int userInput = 0;
        while (userInput ! = 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("--1.Start Breathing Activity");
            Console.WriteLine("--2.Start Reflecting Activity");
            Console.WriteLine("--3.Start Listing Activity");
            Console.WriteLine("--4.Quit");
            Console.Write("Select a choice from the Menu Options");
            string userChoice = Console.ReadLine();

            if (int.TryParse(userChoice, out _))
            {
                userInput = int.Parse(userChoice);
                if (userInput == 1)
                {
                    Console.Clear();
                    BreathingActivity  myActivity = new BreathingActivity ("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                    myActivity.Run();
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    ReflectingActivity  myActivity = new ReflectingActivity ("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. this will help you recognize the power you have and how you can use it in other aspects of your life.");
                    myActivity.Run();
                }
                else if(userInput ==3)
                {
                    Console.Clear();
                    ListingActivity  myActivity = new ListingActivity ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    myActivity.Run();
                }
                else if(userInput == 4)
                {
                    Console.WriteLine("That's it!");
                }


            }

        }

        //for (int i = 5; i > 0; i--)
        //{
            //Console.Write(".");
            //Thread.Sleep(1000);
            //Console.Write("\b \b");
        //}

        //Console.WriteLine(".");
        //DateTime startTime = DateTime.Now;
        //DateTime endTime = startTime.AddSeconds(8);

        //int i = 0;

        //while (DateTime.Now < endTime)
        //{
            //string s = animationStrings[i];
            //Console.Write(".");
            //Thread.Sleep(1000);
            //Console.Write("\b\b");
        //}
        //Console.WriteLine("Done.");
    }
}