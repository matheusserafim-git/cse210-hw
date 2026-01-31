using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Address address1 = new Address("123 main st", "provo", "utah", "USA");
        Customer customer1 = new Customer("John Does", address1);
        Order  order1 = new Order(customer1, 5);
        Product product1 = new Product("laptop", 5, 800, 1);
        Product product2 = new Product("mouse", 2, 50, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        orders.Add(order1);

        Address address2 = new Address("456 zion st", "new york", "NY", "Canada");
        Customer customer2 = new Customer("Jane Ayre", address2);
        Order order2 = new Order(customer2, 35);
        Product product3 = new Product("Phone", 1, 1000, 1);
        Product product4 = new Product("Headphones", 3, 200, 2);
        Product product5 = new Product("Charger", 4, 40, 3);
        order2.AddProduct(product3);
        order2.AddProduct(product4);   
        order2.AddProduct(product5);
        orders.Add(order2);


        foreach (Order order in orders)
        {
            Console.WriteLine($"Total cost: ${order.TotalCost()}");
            Console.WriteLine($"shipping label: {order.ShippingLabel()}");
            Console.WriteLine("------------");
            Console.WriteLine($"Packing Label: {order.PackingLabel()}");

            Console.WriteLine("//////////////////////////////////////////");
        }
    }
}