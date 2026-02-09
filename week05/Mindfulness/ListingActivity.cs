
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random random = new Random();

    public ListingActivity() : base("Listing Activity",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
    0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetDurationFromUser();
        IncrementTotalActivities();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("You may begin listing...");
        GetListFromUser();
    
        Console.WriteLine($"You listed {_count} items!");
    
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who have you helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
       int index = random.Next(_prompts.Count);
       return _prompts [index];
        
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        Console.WriteLine("Start listing items. Press Enter after each one.");

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string item = Console.ReadLine();
            userList.Add(item);
        }

        _count = userList.Count;

        return  userList;
    }
}