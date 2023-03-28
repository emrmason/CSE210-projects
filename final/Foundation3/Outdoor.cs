using System;
using System.Collections;

class Outdoor : Event
{
    protected string _weather;

    public Outdoor()
    {

    }
    public Outdoor(string forecast)
    {
        _weather = forecast;
    }


}