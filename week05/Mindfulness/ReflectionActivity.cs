class ReflectionActivity : Activity
{

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience."
    )
    {
    }
    public void Run()
    {
        Random random = new Random(); 

        string[] prompts =
        {
            "Think about a time when you did something difficult.",
            "Think about a time when you helped someone.",
            "Think about a time when you overcame a challenge.",
            "Think about a time when you learned something important."
        };
        string[] questions =
        {
            "Why was this experience meaningful to you?",
            "What did you learn from this experience?",
            "How did this experience help you become stronger?",
            "What would you do differently if you faced the same situation again?"
        };
        bool[] usedQuestions = new bool[questions.Length];
        int index = random.Next(prompts.Length);

        Console.WriteLine(prompts[index]);

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            if (Array.TrueForAll(usedQuestions, used => used))
            {
                Array.Fill(usedQuestions, false);
            }

            int questionIndex = random.Next(questions.Length);

            if (!usedQuestions[questionIndex])
            {
                Console.WriteLine();
                Console.WriteLine(questions[questionIndex]);

                usedQuestions[questionIndex] = true;

                int remaining = duration - elapsed;

                ShowSpinner(Math.Min(3, remaining));
                elapsed += Math.Min(3, remaining);
            }
        }

    }
    
    
}