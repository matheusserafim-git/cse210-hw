using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference ("Proverbs", 3,5,6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture (reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"Words visible: {scripture.VisibleWordCount()}");

            Console.WriteLine("\nPress Enter to hide some words or type 'quit' to Exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
            
                break;

            }

            scripture.HideRandomWords(3);
        }

        // New feature: show number of visible words
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are hidden, the program will finish. Goodbye!");
    }
}