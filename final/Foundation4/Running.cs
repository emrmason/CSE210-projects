using System;

class Running : Activity
{
    protected float _distance;

    public Running(float dist)
    {
        string date = _date;
        int time = _minutes;
        _distance = dist;

    }

    public Running()
    {

    }
    public override string getDistance()
    {
        return "";
    }

}