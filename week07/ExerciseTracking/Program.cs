using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("Running", 30, "01-june-2025", 5);
        Cycling cycle = new Cycling("Cycling", 45, "02-june-2025", 20);
        Swimming swim = new Swimming("Swimming", 60, "03-june-2025", 40);

        Console.WriteLine(run.GetSummary());
        Console.WriteLine(cycle.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }
}