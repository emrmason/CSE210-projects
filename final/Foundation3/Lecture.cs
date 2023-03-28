using System;
using System.Collections;

class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;
    protected string _lectureSummary;

    public Lecture()
    {

    }
    public Lecture(string speaker, int seats)
    {
        string type = _type;
        string date = _date;
        string time = _time;
        string addy = _address;
        _speaker = speaker;
        string desc = _description;
        _capacity = seats;
        _lectureSummary = $"{_speaker}, {desc}, {date} {time}, at {addy}. {_capacity} Seats are available.";
        
    }
    
}