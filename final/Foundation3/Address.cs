using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public string ZipCode
    {
        get { return _zipCode; }
        set { _zipCode = value; }
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_zipCode}";
    }
}
