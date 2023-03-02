using System;

class Square : Shape
{
    double _side;

    public double getSide()
    {
        return _side;
    }

    public void setSide(double side)
    {
        _side = side;
    }

    public override double getArea()
    {
        return _side * _side;
    }
}