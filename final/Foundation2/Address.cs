using System;

class Address
{
    List<Address> addresses = new List<Address>();
    public int _custID;
    public string _addString;
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;
    private bool _inUS;
    public int shipChg;

    public Address()
    {

    }
    public Address(int custID, string street, string city, string state, string zip, string country)
    {
        custID = _custID;
        street = _street;
        city = _city;
        state = _state;
        zip = _zip;
        country = _country;

    }
    public string newAddress(int custID)
    {
        custID = _custID;
        string strAdd = _street;
        string city = _city;
        string state = _state;
        string zip = _zip;
        string country = _country;
        Address addy1 = new Address(_custID, _street, _city, _state, _zip, _country);
        addresses.Add(addy1);
        _addString = $"{_street},\n{_city}, {_state} {_zip}\n{_country}";
        return _addString;
        
    }

    public double IsInUS(string country)
    {
        country = _country;
        double shipChg = 0.00;
        if(_country == "USA" || _country == "US")
        {
            _inUS = true;
            shipChg = 5.00;
        }
        else
        {
            _inUS = false;
            shipChg = 35.00;
        }

        return shipChg;
    }


}