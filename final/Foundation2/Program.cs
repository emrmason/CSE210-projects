using System;

class Program
{
    static void Main(string[] args)
    {

        List<Order> orders = new List<Order>();
        List<Product> products = new List<Product>();

        Address address1 = new Address("1234 Main Street", "Santa Clarita", "CA", "USA");
        Customer customer1 = new Customer("Jane Doe", address1);

        
        Order order1 = new Order(products, customer1);



    }
}