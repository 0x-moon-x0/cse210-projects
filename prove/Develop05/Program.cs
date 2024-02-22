// added ascii "good job" message with a confetti animation when the user completes
// a checklist goal and recieves a bonus.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}