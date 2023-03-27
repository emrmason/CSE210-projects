using System;

class Order
{
    List<Product> products = new List<Product>();
    List<Customer> customers = new List<Customer>();

 
    private int _orderNumber;

    public Customer customer;

    public Order()
    {

    }

    public void newOrder()
    {
        Console.WriteLine("Enter the new order number: ");
        _orderNumber = Int32.Parse(Console.ReadLine());
        Customer customer = new Customer();
        customer.createCustomer();
        customers.Add(customer);
        Address address = new Address();
        address.newAddress();
        
        Product prod1 = new Product();
        prod1.newProduct();
        customer.shipLabel();
        packLabel(_orderNumber);

    }

    // public void displayShipLabel(string name, string address)
    // {
    //     string shipLabel = $"{custName}\n{address}";
    //     Console.WriteLine(shipLabel);

    // }
    public void packLabel(int orderNum)
    {
        orderNum = _orderNumber;
        string prodLabel = "";

        foreach(Product product in products)
        {
            string name = product._prodName;
            int number = product._prodID;
            int quantity = product._quantity;
            prodLabel = $"Item: {name} ({number}), Quantity: {quantity}";
        }

        string packLabel = $"{orderNum}\n{prodLabel}";
        Console.WriteLine(packLabel);

    }
    // public float totalCost()
    // {
        

    // }
}