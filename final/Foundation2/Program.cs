using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Soap", "A001", 1.50, 4);
        Product p2 = new Product("Air Freshener", "A023", 10.20, 2);
        Product p3 = new Product("House Plant", "D363", 5.30, 1);
        Product p4 = new Product("Lamp", "C111", 23.99, 1);
        Product p5 = new Product("Tissue Box", "A010", 13.10, 5);
        Product p6 = new Product("Shoe Rack", "F002", 30, 1);

        Address a1 = new Address("8144C Maxwell Farm Rd", "Chico", "CA", "USA");
        Customer c1 = new Customer("Jane Forester", a1);

        Address a2 = new Address("Stamford Golf Club, Broadbent Close", "Tameside", "England", "UK");
        Customer c2 = new Customer("Blake Jones", a2);

        // Order 1

        List<Product> productsOrder1 = new List<Product> {p1, p3, p5, p2};
        Order order1 = new Order(productsOrder1, c1);

        Console.WriteLine("Order 1:");
        Console.WriteLine();
        Console.WriteLine($"Packing label\n{order1.CreatePackingLabel()}");
        Console.WriteLine($"Shipping label\n{order1.CreateShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total cost (with shipping): ${order1.CalculateTotal()}");
        Console.WriteLine();

        // Order 2

        List<Product> productsOrder2 = new List<Product> {p4, p6};
        Order order2 = new Order(productsOrder2, c2);

        Console.WriteLine("Order 2:");
        Console.WriteLine();
        Console.WriteLine($"Packing label\n{order2.CreatePackingLabel()}");
        Console.WriteLine($"Shipping label\n{order2.CreateShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total cost (with shipping): ${order2.CalculateTotal()}");        
    }
}