using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Random random = new Random();
        int numberToHide = random.Next(1, 5);

        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(reference1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.");

        Reference reference2 = new Reference("John", 3, 16);
        Scripture scripture2 = new Scripture(reference2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        string userInput = "";
        Console.WriteLine(scripture2.GetDisplayText());

        while (userInput != "quit")
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();

            if (!scripture2.IsCompletelyHidden())
            {
                Console.Clear();
                scripture2.HideRandomWords(numberToHide);
                Console.WriteLine(scripture2.GetDisplayText());
            }
            else if (userInput == "quit")
            {
                break;
            }
            else
            {
                break;
            }
        }

    }
}