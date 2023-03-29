using System;

class Order
{
    // List<Product> products = new List<Product>();
    public int _custID;
    public string _orderNumber;
    public string _product;
    public int _quantity;

    List<string> products = new List<string>();

    public Order()
    {

    }
    public Order(int custID, string ordNumber, Product product)
    {
        _custID = custID;
        _orderNumber = ordNumber;
        Product product1 = product;

    }

    // public string newOrder()
    // {
    //     Console.WriteLine("Enter the customer number: ");
    //     int custID = Int32.Parse(Console.ReadLine());
    //     Console.WriteLine("Enter the new order number: ");
    //     _orderNumber = Console.ReadLine();
    //     Address address = new Address();
    //     address.newAddress(custID);
    //     Product product = new Product();
    //     product.addProducts();
    //     string _product = $"{product._prodID}. {product._prodName}, {product._quantity}";
    //     products.Add(_product);
    //     return _product;
    // }

}