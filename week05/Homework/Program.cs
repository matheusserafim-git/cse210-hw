using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Silvester", "fractions");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("lucia", "Math", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("marta Silva", "Brazilian History", "The live of Dom Pedro II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    
    }
}