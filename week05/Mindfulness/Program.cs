using System;

class Program
{
    static void Main(string[] args)
    { 
        string choice = "";
        // Creativity: Tracks the number of mindfulness activities completed
        // during the current program session and displays the total when the user quits.
        int completedActivities = 0;

        while (choice != "4") 
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");   
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                
                activity.ShowStartingMessage();
                activity.Run();
                activity.ShowEndingMessage();
                completedActivities++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();

                activity.ShowStartingMessage();
                activity.Run();
                activity.ShowEndingMessage();
                completedActivities++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();

                activity.ShowStartingMessage();
                activity.Run();
                activity.ShowEndingMessage();
                completedActivities++;
            }
            else if (choice == "4")
            {
                Console.WriteLine($"You completed {completedActivities} mindfulness activities.");
                Console.WriteLine("Goodbye!");
            }
            Console.WriteLine();
        }
    }
}