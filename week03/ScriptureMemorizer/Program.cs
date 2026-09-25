using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: The program only selects words that are still visible,
        // so a word that is already hidden will not be selected again.
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press Enter to continue or type 'quit': ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                return;
            }

            scripture.HideRandomWords();
            Console.Clear();
        }

        Console.WriteLine(scripture.GetDisplayText());
    }
}
