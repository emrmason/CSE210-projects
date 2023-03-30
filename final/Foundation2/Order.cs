using System;

class Order
{
    List<Product> _products = new List<Product>();
    public Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }


// clean this up!!!
    public double totalPrice(Product product)
    {
        double totalPrice = 100.00;
        return totalPrice;
    }

    public void shipLabel(Customer customer)
    {

    }

    public void packLabel(Customer customer)
    {

    }


}