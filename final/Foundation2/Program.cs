using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {

        List<Order> orders = new List<Order>();
        List<Product> products = new List<Product>();
        List<Product> orderProds = new List<Product>();

        Product product1 = new Product(1, "50 foot tarpaulin", 50.00, 1);
        products.Add(product1);
        Product product2 = new Product(2, "5 man outdoor tent", 100.00, 1);
        products.Add(product2);
        Product product3 = new Product(3, "Camping stove", 45.00, 1);
        products.Add(product3);
        Product product4 = new Product(4, "Backpack", 35.00, 1);
        products.Add(product4);
        Product product5 = new Product(5, "Hiking boots", 75.00, 2);
        products.Add(product5);
        Product product6 = new Product(6, "Waterproof rain jacket", 40.00, 1);
        products.Add(product6);
        Product product7 = new Product(7, "Dehydrated meals", 20.00, 10);
        products.Add(product7);
        Product product8 = new Product(8, "Fire starting kit", 10.00, 1);
        products.Add(product8);
        Product product9 = new Product(9, "Camping cook pot", 15.00, 1);
        products.Add(product9);
        Product product10 = new Product(10, "Water filter", 15.00, 1);
        products.Add(product10);
        Product product11 = new Product(11, "50 foot rope", 25.00, 1);
        products.Add(product11);

        Address address1 = new Address("1234 Main Street", "Santa Clarita", "CA", "USA");
        Customer customer1 = new Customer("Jane Doe", address1);

        Order order1 = new Order(orderProds, customer1);
        orderProds.Add(product1);
        orderProds.Add(product3);
        orderProds.Add(product7);
        order1.packLabel(orderProds, customer1);





    }
}