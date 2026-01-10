using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   

           Random random = new Random();
           int number =random.Next(1,101);
            int attempts = 0;

            while (true)
            {
                Console.Write("What is your guess? ");
                int userGuess = int.Parse(Console.ReadLine());
                attempts++;

                if (userGuess > number)
                    Console.WriteLine("Lower");
                else if (userGuess < number)
                    Console.WriteLine("Bigger");
                else
                {
                    Console.WriteLine("You're right!!!!");
                    break;
                }
            } 

            Console.WriteLine($"You guessed the number in {attempts} attempts.");
    }   
}