using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
     // First Order - Anne Karine Laguerre (Lives in Coram, NY)
        Address address1 = new Address("12 Middle Country Rd", "Coram", "NY", "USA");
        Customer customer1 = new Customer("Anne Karine Laguerre", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Wireless Mouse", "A101", 15.99, 2);
        Product product2 = new Product("USB-C Cable", "A102", 9.50, 3);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        // Second Order - Peterson Trazil (Lives outside USA)
        Address address2 = new Address("234 Rue des Palmiers", "Port-au-Prince", "Ouest", "Haiti");
        Customer customer2 = new Customer("Peterson Trazil", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Bluetooth Speaker", "B201", 29.99, 1);
        Product product4 = new Product("Portable Charger", "B202", 22.99, 2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + order2.GetTotalPrice());
    
    }
}