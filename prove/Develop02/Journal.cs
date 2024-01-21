public class Journal
{
    public List<Entry> _entries = new List<Entry>(); // instatinating a list of Entry objects

    public void AddEntry(Entry newEntry) // method that adds new entries to the list of all journal entries
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll() // method that iterates through every entry in the list and displays it using the Display() method of the Entry class
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file) // method that saves the all created entries to a file
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|~|{entry._promptText}|~|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file) // method that loads all saved entries from a file
    {
        // I tried this too, but it threw me the same error and didn't even write data into a file

        // using (StreamWriter inputFile = new StreamWriter(file))
        // {
            // string[] lines = System.IO.File.ReadAllLines(file);

            // foreach (string line in lines)
            // {
                // string[] parts = line.Split("|~|");

                // string date = parts[0]; 
                // string prompt = parts[1];
                // string text = parts[2];

                // Entry entry = new Entry();

                // entry._date = date;
                // entry._promptText = prompt;
                // entry._entryText = text;

                // AddEntry(entry);
            // }
        // }

        // this doesn't get in the way of writing data into a file, but doesn't read/display it

        string[] lines = System.IO.File.ReadAllLines(file); // reading all lines in a file

        foreach (string line in lines)
        {
            string[] parts = line.Split("|~|"); // ignoring separators and splitting each line into parts

            string date = parts[0]; 
            string prompt = parts[1];
            string text = parts[2];

            foreach (Entry entry in _entries)
            {
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = text;
            }
        }
    }
}