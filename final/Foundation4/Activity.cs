using System;

class Activity
{
    protected string _date;
    // length = time in minutes doing activity
    protected int _minutes;

    public Activity()
    {

    }

    public Activity(string date, int time)
    {
        _date = date;
        _minutes = time;
    }

    public virtual string getDistance()
    {
        return "";
    }
    public virtual string getSpeed()
    {
        return "";
    }
    
    public virtual string getPace()
    {
        return "";
    }
    public virtual string getSummary()
    {
        return "";
    }

}