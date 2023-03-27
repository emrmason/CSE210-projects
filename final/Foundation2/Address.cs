using System;

class Address
{
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
    public Address(string street, string city, string state, string zip, string country)
    {
        street = _street;
        city = _city;
        state = _state;
        zip = _zip;
        country = _country;

    }
    public void newAddress()
    {
        string strAdd = _street;
        string city = _city;
        string state = _state;
        string zip = _zip;
        string country = _country;
        string addString = $"{_street},\n{_city}, {_state} {_zip}\n{_country}";
        
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