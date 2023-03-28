using System;

class Customer
{
    List<Address> addresses = new List<Address>();
    List<Customer> customers = new List<Customer>();

    private string _custName;
    private int _custID;
    private string _address;

    // private bool inUS;

    public Customer()
    {

    }
    public Customer(string name, int custID, string addy)
    {
        name = _custName;
        custID = _custID;
        addy = _address;
    }

    public void createCustomer()
    {
        Console.WriteLine("What is the customer's name? ");
        _custName = Console.ReadLine();
        Console.WriteLine("Please enter the new customer ID: ");
        _custID = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the street address: ");
        string strAdd = Console.ReadLine();
        Console.WriteLine("Enter the city: ");
        string city = Console.ReadLine();
        Console.WriteLine("Enter the state: ");
        string state = Console.ReadLine();
        Console.WriteLine("Enter the zip: ");
        string zip = Console.ReadLine();
        Console.WriteLine("Enter the country: ");
        string country = Console.ReadLine();
        Address address1 = new Address(_custID, strAdd, city, state, zip, country);
        string _addyString = ($"{strAdd}\n{city}, {state} {zip}\n{country}");
        // _address = address._addString;
        Customer customer1 = new Customer(_custName, _custID, _addyString);
        customers.Add(customer1);
        // Console.WriteLine($"{_custName} added to Customers.");

    }
    public void shipLabel(int custID)
    {
        string shipLabel = $"{_custName},\n{_address}";
        Console.WriteLine(shipLabel);
    }
    public void displayCustomers()
    {
        foreach(Customer customer in customers)
        {
            string name = customer._custName;
            int id = customer._custID;
            Console.WriteLine($"{id}. {name}");
        }

    }

}