using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string Grade;

        if (grade >= 90)
            Grade = "A";
        else if (grade <=89 && grade >= 80)
            Grade = "B";
        else if (grade <=79 && grade >= 70)
            Grade = "C";
        else if (grade <=69 && grade >= 60)
            Grade = "D";
        else
            Grade = "F";

        Console.WriteLine($"Your grade is:{Grade}");

            if (grade > 69)
            {
            Console.WriteLine("Congratulations. You were approved");
            }
            else
            {
               Console.WriteLine("You weren´t approved, but God know your efforts and will help you to be better next time!");
            }
    }
}