using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;  // or some starting value
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        while (userNumber != 0);
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
           if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if ( number > 0 && number < smallestPositive )
            {
                smallestPositive = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }      
    }
}