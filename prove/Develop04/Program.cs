using System;

// exceeded the requirements by accounting for invalid input in the menu and adding an extra step to the
// breathing activity (holding breath for 7 seconds, as according to the 4-7-8 breathing principle)

class Program
{
    static void Main(string[] args)
    {
       string userSelection = "";

       while (userSelection != "4")
       {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");

            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");

            Console.Write("Select a choice from the menu: ");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();

                breathingActivity.Run();
            }

            else if (userSelection == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();

                reflectingActivity.Run();
            }

            else if (userSelection == "3")
            {
                ListingActivity listingActivity = new ListingActivity();

                listingActivity.Run();
            }
            
            else if (userSelection == "4")
            {
                break;
            }

            else 
            {
                Console.WriteLine();
                Console.WriteLine("Invalid selection, please enter a number available on the menu.");
            }
       }
    }
}