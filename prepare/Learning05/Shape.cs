using System;

class Shape
{
    string _color;

    public string getColor()
    {
        return _color;
    }

    public void setColor(string color)
    {
        _color = color;
    }

    public virtual double getArea()
    {
        return -1;
    }
}