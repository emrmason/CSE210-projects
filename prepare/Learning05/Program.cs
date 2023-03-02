using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
        square1.setColor("orange");
        square1.setSide(15);
        double s1Area = square1.getArea();


        Console.WriteLine($"The area is {s1Area}.");
    }
}