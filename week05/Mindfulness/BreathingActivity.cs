class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding your breathing."
    )
    {
    }

    public void Run()
    {
        int duration = GetDuration();
        int halfDuration = duration / 2;

        Console.WriteLine("Breathe in...");
        ShowSpinner(halfDuration);

        Console.WriteLine("Breathe out...");
        ShowSpinner(halfDuration);
    }
    
}