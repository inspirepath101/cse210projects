public class PromptGenerator

    List<string> prompts;
    
    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "Who was the most interesting people I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "How have you felt when reaching out to help someone today?"
        };   
    }
    public string GetRandomPrompt()
    {
        string randomPrompt = "";
        int randomIndex = new Random().Next(prompts.Count);

        randomPrompt = prompts[randomindex];

        return randomPrompt;
    }





