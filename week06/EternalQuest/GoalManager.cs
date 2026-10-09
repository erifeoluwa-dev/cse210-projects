using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public void SaveScore(int score, List<Goal> goals)
    {
         using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            outputFile.WriteLine($"Score|{score}");
            foreach (Goal goal in goals)
            {
                if (goal is SimpleGoal)
                {
                    outputFile.WriteLine(
                        $"SimpleGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.IsComplete()}"
                    );
                }
                else if (goal is EternalGoal)
                {
                    outputFile.WriteLine(
                        $"EternalGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}"
                    );
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    outputFile.WriteLine(
                        $"ChecklistGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{checklistGoal.GetTarget()}|{checklistGoal.GetAmountCompleted()}|{checklistGoal.GetBonus()}|{checklistGoal.IsComplete()}"
                    );
                }
            }
        }    
        Console.WriteLine("Goals saved successfully.");
    }
    public int LoadGoals(List<Goal> goals)
    {
        int score = 0;

        if (!File.Exists("goals.txt"))
        {
            return score;
        }

        string[] lines = File.ReadAllLines("goals.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts[0] == "Score")
            {
                score = int.Parse(parts[1]);
            }
            else if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal = new SimpleGoal(name, description, points);

                if (isComplete)
                {
                    goal.RecordEvent();
                }

                goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal = new EternalGoal(name, description, points);

                goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    amountCompleted,
                    bonus
                );

                goals.Add(goal);
            }
        }

        return score;
    }
}       