public class Product
{
    private string _name;
    private string _product_id;
    private decimal _price_per_unit;
    private int _quantity;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string ProductId
    {
        get { return _product_id; }
        set { _product_id = value; }
    }

    public decimal PricePerUnit
    {
        get { return _price_per_unit; }
        set { _price_per_unit = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public decimal TotalCost()
    {
        return _price_per_unit * _quantity;
    }
}
