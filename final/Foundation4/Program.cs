using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("22 May 2024", 45, 20);
        activities.Add(running);

        Cycling cycling = new Cycling("15 Mar 2024", 30, 15);
        activities.Add(cycling);

        Swimming swimming = new Swimming("01 Jul 2024", 60, 10);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}