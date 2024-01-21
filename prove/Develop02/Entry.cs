public class Entry
{
    static DateTime currentTime = DateTime.Now; // getting the current date and time
    
    public string _date = currentTime.ToShortDateString(); // and assigning it to the _date variable
    public string _promptText; 
    public string _entryText;

    public void Display() // method that displays each individual prompt, entry, and its date
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
}