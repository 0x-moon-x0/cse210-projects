using System;
using System.ComponentModel.Design;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        // instantinating a journal and a prompt generator
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // welcome message
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");

        string userSelection = "";

        // keep looping until the user chooses to quit
        while (userSelection != "5")
        {
            // user menu
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");

            userSelection = Console.ReadLine();
            Console.WriteLine();

            if (userSelection == "1") // if the user wants to create a new entry
            {
                Entry entry = new Entry(); // creating a new entry object
                journal.AddEntry(entry); // and adding it to the list of entries in the journal
                string prompt = promptGenerator.GetRandomPrompt(); // gettig a random prompt
                entry._promptText = prompt; // and assigning it to the _promptText variable in the Entry class
                
                Console.WriteLine($"{prompt}"); // displaying the random prompt for the user
                Console.Write("> ");
                entry._entryText = Console.ReadLine(); // getting input from the user and assigning it to the _entryText variable in the Entry class
            }
            else if (userSelection == "2") // if the user wants to display all entries
            {
                journal.DisplayAll();
            }
            else if (userSelection == "3") // if the user wants to load from a file
            {
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
            else if (userSelection == "4") // if the user wants to save to a file
            {
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }
        }
    }
}