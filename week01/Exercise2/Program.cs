using System;
using System.Net.Security;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulation, You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        int lastDigit = percent % 10;

        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F" && (sign == "+" || sign == "-"))
        {
            sign = "";
        }
        Console.WriteLine($"Your final grade is: {letter}{sign}");

    }
}