
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    //increment total activities run
    private static int _totalActivities = 0;

    protected void IncrementTotalActivities()
    {
        _totalActivities++;
    }

    public static int GetTotalActivitiesRun()
    {
        return _totalActivities;
    }


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Add Get´s
    public string GetName()
    {
        return _name;
    }
    
    public string GetDescription()
    {
        return _description;
    }


    public void DisplayStartingMessage()
    {   
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
    }

    public void GetDurationFromUser()
    {
        Console.Write("Enter the duration in seconds:");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thanks for using {_name} for {_duration} seconds. Well done!");
        Console.WriteLine("Take care!");
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int totalTime = seconds * 1000;
        int index = 0;

        while (totalTime > 0)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index = (index + 1) % spinner.Length;
            totalTime -= 250;
        }
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine();
    }
}