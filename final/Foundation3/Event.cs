using System;
using System.Collections;

class Event
{
    protected string _title;
    protected string _description;
    protected string _type;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventSummary;
    public Event()
    {

    }
    public Event(string title, string desc, string type, string date, string time, string addy)
    {
        _title = title;
        _description = desc;
        _type = type;
        _date = date;
        _time = time;
        _address = addy;
        _eventSummary = $"{_title}, {_description}, {_date} {_time} at {_address}.";

    }

}