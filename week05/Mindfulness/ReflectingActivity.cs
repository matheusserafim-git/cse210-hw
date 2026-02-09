using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random random = new Random();

    public ReflectingActivity() : base("Reflection Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetDurationFromUser();
        IncrementTotalActivities();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"----{GetRandomPrompt()}----");
        Console.WriteLine();

        Console.Write("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

       while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
        }
        

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts [index];
    }

    private string GetRandomQuestion()
    {
        int index = random.Next(_questions.Count);
        return _questions[index];
    }


    public void DisplayPrompt()
    {
        Console.WriteLine($"{GetRandomPrompt()}");

    }

    public void DisplayQuestion()
    {
        if (_duration != 0)
        {
           Console.WriteLine($"{GetRandomQuestion()}");
           Thread.Sleep(10000);  
        }

        return;
    }
}