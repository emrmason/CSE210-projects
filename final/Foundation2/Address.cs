using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;
    private bool _inUS;
    private int ship;

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
    public string newAddress(string strAdd, string city, string state, string zip, string country)
    {
        strAdd = _street;
        city = _city;
        state = _state;
        zip = _zip;
        country = _country;
        IsInUS(country);
        string addString = $"{_street},\n{_city}, {_state}, {_zip},\n{_country}";
        return addString;
    }

    public bool IsInUS(string country)
    {
        if(country == "USA" || country == "US")
        {
            bool _inUS = true;
        }
        else
        {
            bool _inUS = false;
        }

        if(_inUS == true)
        {
            int ship = 5;
        }
        else
        {
            int ship = 35;
        }
        return _inUS;
    }


}