public class Address
{
    private string _street_address;
    private string _city;
    private string _state_province;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _street_address = streetAddress;
        _city = city;
        _state_province = stateProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street_address}\n{_city}, {_state_province}, {_country}";
    }
}
