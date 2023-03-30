using System;
using System.Collections;

class Customer
{
    private string _custName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _custName = name;
        _address = address;
    }
    
    public string getName()
    {
        return $"{_custName}";
    }
    public string getAddy()
    {
        string custAdd = _address.ToString();
        return $"{custAdd}";
    }
    // public void shipLabel()
    // {
    //     string shipLabel = $"{_custName},\n{_address}";
    //     Console.WriteLine(shipLabel);
    // }



}