using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "P001", 500, 2);
        Product product2 = new Product("Mouse", "P002", 25, 3);
        Product product3 = new Product("Keyboard", "P003", 50, 1);
        Product product4 = new Product("3D Clock", "P012", 10, 5);
        Product product5 = new Product("Sound System", "P004", 300, 1);
        Product product6 = new Product("Remote Control", "P008", 5, 1);

        Address address1 = new Address("97 Rumuolumini", "Port-Harcourt", "Rivers", "Nigeria");
        Address address2 = new Address("102 Ada George", "Port-Harcourt", "Rivers", "Nigeria");

        Customer customer1 = new Customer("John Okpara", address1);
        Customer customer2 = new Customer("Stev Smith", address2);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product2);
        products1.Add(product3);

        List<Product> products2 = new List<Product>();
        products2.Add(product4);
        products2.Add(product5);
        products2.Add(product6);

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);
        
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}