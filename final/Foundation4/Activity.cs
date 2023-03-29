using System;

abstract class Activity
{
    protected string _date;
    // length = time in minutes doing activity
    protected int _length;

    Activity()
    {

    }

    Activity(string date, int time)
    {
        _date = date;
        _length = time;
    }

}