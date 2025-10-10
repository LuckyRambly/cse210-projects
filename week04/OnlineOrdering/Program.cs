using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Order 1 USA

        // Address (USA)
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");

        // Customer
        Customer customer1 = new Customer("Camaron Johnson", address1);

        // Products
        Product prodA = new Product("HP Victus 15 RTX 3050 32GB Ram 1TB", "LG001", 999.99, 1); // it should be 999.99
        Product prodB = new Product("Generic Mouse", "MO550", 25.50, 2);     // it should be 51.00

        // Order
        Order order1 = new Order(customer1);
        order1.AddProduct(prodA);
        order1.AddProduct(prodB);
        // Shipping cost from USA: 5.00
        // Final cost: 999.99 + 51.00 + 5.00 = 1055.99

        Console.WriteLine("----------Processing order 1----------");
        
        // Mostrar resultados llamando a los métodos encapsulados
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\n");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\n");
        Console.WriteLine($"Total price: ${order1.CalculateTotalCost():F2}");
        
        Console.WriteLine("-------------------------------------");

        // Order 2 Internacional

        // Address International
        Address address2 = new Address("Av. Francisco de Miranda", "Caracas", "CA", "Venezuela");

        // Customer
        Customer customer2 = new Customer("Raido Gutierrez", address2);

        // Products
        Product prodC = new Product("Gaturro Plush", "GPNCK", 45.00, 3); // it should be 135.00
        Product prodD = new Product("Mechanic keyboard HK300", "HK300", 29.99, 4); // it shpuld be 199.96

        // Order
        Order order2 = new Order(customer2);
        order2.AddProduct(prodC);
        order2.AddProduct(prodD);
        // International shipping 35.00
        // Total cost = 199.96+ 135 = 334.96

        Console.WriteLine("----------Processing order 2----------");
        
        // Mostrar resultados
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\n");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\n");
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost():F2}");
        
        Console.WriteLine("-----------------------");
    }
}