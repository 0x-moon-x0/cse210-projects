public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {}

    public void Run()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        GetListFromUser();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> userList = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }

        _count = userList.Count();

        Console.WriteLine($"You have listed {_count} items!");

        return userList;
    }
}