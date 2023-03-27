using System;

class Product
{
    List<Product> products = new List<Product>();

    public int _prodID;
    public string _prodName;
    private double _price;
    public int _quantity;

    public Product()
    {

    }

    public Product(int ID, string prod, double cost, int quant)
    {
        ID = _prodID;
        prod = _prodName;
        cost = _price;
        quant = _quantity;

    }

    public void newProduct()
    {
        Console.WriteLine("Enter the product number: ");
        _prodID = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the product name: ");
        _prodName = Console.ReadLine();
        Console.WriteLine("What is the price for this product(in US Dollars)? ");
        _price = Double.Parse(Console.ReadLine());
        Console.WriteLine("How many of this product would you like to order? ");
        _quantity = Int32.Parse(Console.ReadLine());
        string prod1 = $"{_prodID} ({_quantity}), {_prodName}";
        Product product = new Product(_prodID, _prodName,_price, _quantity);
        products.Add(product);
    }

    public double totalCost(int quantity, float price)
    {
        double total = quantity * price;
        Console.WriteLine($"Total Cost: ${total}");
        return total;
    }
}