using System;

class Customer
{
    private string _custName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _custName = name;
        _address = address;
    }
    
    public void shipLabel()
    {
        string shipLabel = $"{_custName},\n{_address}";
        Console.WriteLine(shipLabel);
    }



}