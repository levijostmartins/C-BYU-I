public class Customer
{
    private string _name;
    private Address _address;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}
