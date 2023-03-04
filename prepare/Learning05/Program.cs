using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square square1 = new Square();
        square1.setColor("orange");
        square1.setSide(15);
        double s1Area = square1.getArea();
        string s1Color = square1.getColor();
        shapes.Add(square1);

        Rectangle rect1 = new Rectangle();
        rect1.setColor("blue");
        rect1.setLength(15);
        rect1.setWidth(30);
        double rect1Area = rect1.getArea();
        string rect1Color = rect1.getColor();
        shapes.Add(rect1);

        Circle circle1 = new Circle();
        circle1.setColor("pink");
        circle1.setRadius(10);
        double circle1Area = circle1.getArea();
        string circle1Color = circle1.getColor();
        shapes.Add(circle1);


        foreach(Shape shape in shapes)
        {
            Shape shape1 = new Shape();
            string color = shape.getColor();
            double area = shape.getArea();
            Console.WriteLine($"The area of the {color} {shape} is {area}.");
        }

        // Console.WriteLine($"The area of the {s1Color} square is {s1Area}.");
        // Console.WriteLine($"The area of the {rect1Color} rectangle is {rect1Area}.");
        // Console.WriteLine($"The area of the {circle1Color} circle is {circle1Area}.");

    }
}