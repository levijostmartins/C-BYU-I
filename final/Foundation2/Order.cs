using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        decimal shippingCost = _customer.IsUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Name: {_customer.Name}\nAddress:\n{_customer.Address.GetFullAddress()}";
    }
}
