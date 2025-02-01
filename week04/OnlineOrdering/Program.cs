using System;

class Program
{
    static void Main(string[] args)
    {
        Order order=new Order(new Customer("test", new Address("caden", "clovis", "NM", "USA")));
        Order order1=new Order(new Customer("trial", new Address("coner", "noma", "Paris", "UK")));
        order.AddProduct("bacon", "meat", 6, 5);
        order.AddProduct("eggs", "dairy", 8, 12);
        order1.AddProduct("apple", "fruit", 2, 16);
        order1.AddProduct("sprite", "soda", 3, 4);
        Console.WriteLine($"{order.GetPackingLabel()}: {order.getShippingLabel()}: {order.GetTotalCost()}");
        Console.WriteLine($"{order1.GetPackingLabel()}: {order1.getShippingLabel()}: {order1.GetTotalCost()}");
    }
}