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
        string[] lines = System.IO.File.ReadAllLines(file); // reading all lines in the file into a string array

        foreach (string line in lines)
        {
            string[] parts = line.Split("|~|"); // splitting the lines into parts

            Entry loadEntry = new Entry(); // for every line we create a new entry

            loadEntry._date = parts[0];
            loadEntry._promptText = parts[1];
            loadEntry._entryText = parts[2];

            _entries.Add(loadEntry); // add those loaded entries into the list
        }
    }
}