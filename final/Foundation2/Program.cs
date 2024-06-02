using System;

class Program
{
    static void Main(string[] args)
    {
        var orders = OrderData.GetOrders();

        foreach (var order in orders)
        {
            DisplayOrderDetails(order);
        }
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order.TotalCost());
        Console.WriteLine();
    }
}
