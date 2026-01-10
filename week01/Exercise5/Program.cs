using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = squareNumber(favoriteNumber);

        DisplayResult(squaredNumber, name);
    }
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
     static string PromptUserName()
    {
        Console.Write("What is your name ?");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?");
        int favorite = int.Parse(Console.ReadLine());
        return favorite;
    }
    static int squareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(int squared, string name)
    {
        Console.WriteLine($"{name}, the square of your number is: {squared}");
    }

}