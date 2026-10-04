using System.Collections.Generic;
class ListingActivity : Activity
{
    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can."
    )
    {
    }
    public void Run()
    {
        Random random = new Random();
        List<string> responses = new List<string>();
        string[] prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped recently?",
            "When have you felt the Holy Ghost this month?"
        };
        int index = random.Next(prompts.Length);

        Console.WriteLine(prompts[index]);
        int duration = GetDuration();
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("Enter a response: ");
            string response = Console.ReadLine();
            responses.Add(response);
            int remaining = duration - elapsed;
            int waitTime = Math.Min(3, remaining);

            ShowSpinner(waitTime);
            elapsed += waitTime;
        }
        Console.WriteLine($"You listed {responses.Count} items.");
        
    }

}