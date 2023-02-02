using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        fraction1.setTop(1);
        fraction1.setBottom(1);
        Console.WriteLine(fraction1.GetFractionString(fraction1.getTop(), fraction1.getBottom()));
        Console.WriteLine(fraction1.GetDecimalValue(fraction1.getTop(), fraction1.getBottom()));


        Fraction fraction2 = new Fraction();
        fraction2.setTop(5);
        fraction2.setBottom(1);
        Console.WriteLine(fraction2.GetFractionString(fraction2.getTop(), fraction2.getBottom()));
        Console.WriteLine(fraction2.GetDecimalValue(fraction2.getTop(), fraction2.getBottom()));

        Fraction fraction3 = new Fraction();
        fraction3.setTop(3);
        fraction3.setBottom(4);
        Console.WriteLine(fraction3.GetFractionString(fraction3.getTop(), fraction3.getBottom()));
        Console.WriteLine(fraction3.GetDecimalValue(fraction3.getTop(), fraction3.getBottom()));

        Fraction fraction4 = new Fraction();
        fraction4.setTop(1);
        fraction4.setBottom(3);
        Console.WriteLine(fraction4.GetFractionString(fraction4.getTop(), fraction4.getBottom()));
        Console.WriteLine(fraction4.GetDecimalValue(fraction4.getTop(), fraction4.getBottom()));
        
    
    }
}