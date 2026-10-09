using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        List<Goal> goals = new List<Goal>();
        GoalManager manager = new GoalManager();
        int score = manager.LoadGoals(goals);

        while (choice != "5")
        {
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");

                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points? ");
                    int points = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case "1":
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                            goals.Add(simpleGoal);
                            break;

                        case "2":
                            EternalGoal eternalGoal = new EternalGoal(name, description, points);
                            goals.Add(eternalGoal);
                            break;
                        case "3":
                            Console.Write("What is the target amount? ");
                            int target = int.Parse(Console.ReadLine());

                            Console.Write("What is the bonus amount? ");
                            int bonus = int.Parse(Console.ReadLine());

                            ChecklistGoal checklistGoal = new ChecklistGoal(
                                name,
                                description,
                                points,
                                target,
                                0,
                                bonus
                            );

                            goals.Add(checklistGoal);
                            break;                                     
                    }
                    break;

                case "2":
                    foreach (Goal goal in goals)
                    {
                        string status = goal.IsComplete() ? "[X]" : "[ ]";
                        Console.WriteLine($"{status} {goal.GetName()}");
                    }
                    break;

                case "3":
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i}. {goals[i].GetName()}");
                    }

                    Console.Write("Which goal did you accomplish? ");
                    int goalNumber = int.Parse(Console.ReadLine());
                    
                    if (goalNumber < 0 || goalNumber >= goals.Count)
                    {
                        Console.WriteLine("Invalid goal number.");
                    }
                    else if (goals[goalNumber].IsComplete())
                    {
                        Console.WriteLine("This goal is already completed.");
                    }
                    else
                    {
                        score += goals[goalNumber].RecordEvent();
                    }
                    break;
                case "4":
                    Console.WriteLine($"Your score is: {score}");

                    // Extra feature: recognize the user's progress with score achievements.
                    if (score >= 1000)
                    {
                        Console.WriteLine("Achievement: Eternal Quest Champion!");
                    }
                    else if (score >= 500)
                    {
                        Console.WriteLine("Achievement: Disciplined!");
                    }
                    else if (score >= 300)
                    {
                        Console.WriteLine("Achievement: Committed!");
                    }
                    else if (score >= 100)
                    {
                        Console.WriteLine("Achievement: Beginner!");
                    }
                    else
                    {
                        Console.WriteLine("Achievement: Your journey has begun!");
                    }

                    break;

                case "5":
                    manager.SaveScore(score, goals);
                    Console.WriteLine("Quit");
                    break;
            }
        }
    }
}