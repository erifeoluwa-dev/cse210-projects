using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "";
        do 
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            int guess = -1;
            int countGuess = 0;
            while (guess != magicNumber)
            {    
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                countGuess ++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }    
            }
            Console.WriteLine($"You guessed it in {countGuess} guesses!");
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        while (playAgain == "yes"); 
    }
}