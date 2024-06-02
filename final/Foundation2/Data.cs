using System.Collections.Generic;

public class OrderData
{
    public static List<Order> GetOrders()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer { Name = "John Doe", Address = address1 };
        Product product1 = new Product { Name = "Laptop", ProductId = "1234", PricePerUnit = 1200, Quantity = 2 };
        Product product2 = new Product { Name = "Keyboard", ProductId = "5678", PricePerUnit = 50, Quantity = 1 };
        Product product3 = new Product { Name = "Mouse", ProductId = "9010", PricePerUnit = 20, Quantity = 1 };
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("456 Elm St", "Other City", "NY", "Canada");
        Customer customer2 = new Customer { Name = "Jane Smith", Address = address2 };
        Product product4 = new Product { Name = "Headphones", ProductId = "9012", PricePerUnit = 100, Quantity = 3 };
        Product product5 = new Product { Name = "Monitor", ProductId = "3456", PricePerUnit = 300, Quantity = 1 };
        Product product6 = new Product { Name = "Printer", ProductId = "7890", PricePerUnit = 200, Quantity = 2 };
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        return new List<Order> { order1, order2 };
    }
}
