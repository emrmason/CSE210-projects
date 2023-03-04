using System;

class Circle: Shape
{
    double _radius;

    public double getRadius()
    {
        return _radius;
    }

    public void setRadius(double radius)
    {
        _radius = radius;
    }

    public override double getArea()
    {
        return _radius * _radius * 3.14;
    }
}