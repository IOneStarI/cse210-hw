using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("Agregatna 2", "Kiev",  "UKR");
        Customer customer1 = new Customer("Vlad Didkovskiy", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 1200, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25, 2));

        Address address2 = new Address("2 west grouth", "Leeds", "UK");
        Customer customer2 = new Customer("Sofia Didkovska", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Creame", "K789", 100, 1));
        order2.AddProduct(new Product("Lotion", "M101", 300, 1));

        List<Order> orders = new List<Order> { order1, order2 };
        
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: UAH {order.GetTotalPrice()}");
            Console.WriteLine("--------------------------------");
        }
    }
}