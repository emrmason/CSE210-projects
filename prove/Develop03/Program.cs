using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Scripture scripture = new Scripture();
        Reference reference= new Reference();
        reference.DisplayFullReference();
        scripture.Display();
    }
}