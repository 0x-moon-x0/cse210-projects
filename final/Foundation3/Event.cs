public abstract class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"\nEvent Title: {_title}\nDescription: {_description}\nDate: {_date} at {_time}\nAddress: {_address.ConvertToString()}";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}