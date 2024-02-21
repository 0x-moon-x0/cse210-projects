using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("22 May 2024", 30, 4.8);
        activities.Add(running);

        Cycling cycling = new Cycling("15 Mar 2024", 20, 20.0);
        activities.Add(cycling);

        Swimming swimming = new Swimming("01 Jul 2024", 60, 8);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}