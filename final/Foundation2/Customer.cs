using System;

class Customer
{
    // List<Address> addresses = new List<Address>();
    List<string> customers = new List<string>();

    private string _custName;
    private int _custID;
    public Address address;

    // private bool inUS;

    public Customer()
    {

    }
    public Customer(string name, int custID)
    {
        name = _custName;
        custID = _custID;
    }

    public void createCustomer()
    {
        Console.WriteLine("What is the customer's name? ");
        _custName = Console.ReadLine();
        Console.WriteLine("Please enter the new customer ID: ");
        _custID = Int32.Parse(Console.ReadLine());
        string customer1 = $"{_custID}: {_custName}";
        customers.Add(customer1);

    }
    public void shipLabel()
    {
        string shipLabel = $"{_custName},\n{address}";
        Console.WriteLine(shipLabel);
    }

}