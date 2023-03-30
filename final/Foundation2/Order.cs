using System;
using System.Collections;


class Order
{
    List<Product> _products = new List<Product>();
    public Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer; 
    }


// clean this up!!!
    public double totalPrice(Product product)
    {
        double totalPrice = 100.00;
        return totalPrice;
    }

    public void shipLabel(Customer _customer)
    {
        string name = _customer.getName();
        string addy = _customer.getAddy();        
    }

    public void packLabel(List<Product> _products, Customer _customer)
    {
        string cust = _customer.ToString();
        Console.WriteLine($"{cust}");
        for(int x = 0; x <= _products.Count; x++)
        {
            Console.WriteLine($"{_products}");
        }
    }


}