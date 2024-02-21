public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _street = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string AddressString()
    {
        return $"{_street}\n{_city}, {_state}, {_country}";
    }
}