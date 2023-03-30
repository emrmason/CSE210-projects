using System;
using System.Collections;

class Address
{
    private string _addString;
    private string _street;
    private string _city;
    private string _state;
    public string _country;
    // private bool _inUS;

    public Address()
    {

    }
    public Address(string street, string city, string state, string country)
    {
        street = _street;
        city = _city;
        state = _state;
        country = _country;
        _addString = $"{_street},\n{_city}, {_state}\n{_country}";

    }
    
    public bool inUS()
    {
        if(_country == "US"|| _country == "USA")
        {
            return true;
        }
        return false;
    }

       public string getAddressString()
    {
        return _addString;
    }
//     public string newAddress(int custID)
//     {
//         custID = _custID;
//         string strAdd = _street;
//         string city = _city;
//         string state = _state;
//         string zip = _zip;
//         string country = _country;
//         Address addy1 = new Address(_custID, _street, _city, _state, _zip, _country);
//         addresses.Add(addy1);
//         _addString = $"{_street},\n{_city}, {_state} {_zip}\n{_country}";
//         return _addString;
//     }






}