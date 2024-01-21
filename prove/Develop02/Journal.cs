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

    public void SaveToFile(string file)
    {
        //---
    }

    public void LoadFromFile(string file)
    {
        //---
    }
}