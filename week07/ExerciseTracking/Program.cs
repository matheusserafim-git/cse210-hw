using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("Morning Run", 30, "2024-06-01", 5);
        Cycling cycle = new Cycling("Evening Ride", 45, "2024-06-02", 20);
        Swimming swim = new Swimming("Afternoon Swim", 60, "2024-06-03", 40);

        Console.WriteLine(run.GetSummary());
        Console.WriteLine(cycle.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }
}