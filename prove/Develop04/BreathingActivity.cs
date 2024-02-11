public class BreathingActivity : Activity
{
    public BreathingActivity()
    {}

    public void Run()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            Console.WriteLine();
            Console.WriteLine("Hold your breath... ");
            Thread.Sleep(7000);

            Console.Write("Now breathe out... ");
            ShowCountDown(8);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}