using System;

class Rectangle : Shape
{
    double _length; 
    double _width;

    public double getLength()
    {
        return _length;
    }

    public double getWidth()
    {
        return _width;
    }

    public void setLength(int length)
    {
        _length = length;
    }

    public void setWidth(int width)
    {
        _width = width;
    }

    public override double getArea()
    {
        return _length * _width;
    }


}