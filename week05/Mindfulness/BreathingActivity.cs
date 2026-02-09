

public class BreathingActivity : Activity
{
    //time especific to breathe and breathe out

    private const int _inhaleTime = 3;
    private const int _exhaleTime = 5;

    public BreathingActivity() : base("Breathing Activity",
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
    0)
    { 
    }

    public void Run()
    {
        IncrementTotalActivities();
        DisplayStartingMessage();
        GetDurationFromUser();

        int remainingTime = _duration;

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        while (remainingTime > 0 )
        {

            Console.WriteLine("Breathe in...");
            ShowCountDown(_inhaleTime);
            remainingTime -= _inhaleTime;

            if (remainingTime <= 0) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(_exhaleTime);
            remainingTime -= _exhaleTime;
        }
        DisplayEndingMessage();
    }
}