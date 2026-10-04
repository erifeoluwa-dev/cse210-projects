using System;
using System.Threading;
public class Activity
{
    private int _duration;
    private string _name;
    private string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void ShowStartingMessage()
    {
        Console.WriteLine($"Starting {GetName()}");
        Console.WriteLine(GetDescription());

        Console.Write("Enter the duration: ");
        string input = Console.ReadLine();
        int duration = Convert.ToInt32(input);
        SetDuration(duration);
    }
    public void ShowEndingMessage()
    {
        Console.WriteLine("You have done a great job!");
        Console.WriteLine($"You have completed {GetName()} for {GetDuration()} seconds.");
    }
    public void ShowSpinner(int seconds)
    {
        int elapsed = 0;
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (elapsed < seconds)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(1000);
            Console.Write("\b");
            elapsed++;
            index = (index + 1) % 4;
        }
        Console.WriteLine();
    }
}