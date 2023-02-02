using System;

public class Fraction 
{
    private int _top;
    private int _bottom;

    public string fraction()
    {
        _top = 1;
        _bottom = 1;
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public string wholeFraction(int _top)
    {
        _bottom = 1;
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public string anyFraction(int _top, int _bottom)
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public int getTop()
    {
        return _top;
    }

    public int getBottom(){
        return _bottom;
    }

    public void setTop(int top)
    {
        _top = top;
    }

    public void setBottom(int denom)
    {
        _bottom = denom;
    }

    public string GetFractionString(int _top, int _bottom) 
    {
        string stringFraction = $"{_top}/{_bottom}";
        return stringFraction;
    }

    public double GetDecimalValue(int _top, int _bottom)
    {
        double deciVal =  (double)_top/_bottom;
        return deciVal;
    }

}