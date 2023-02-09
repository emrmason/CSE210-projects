using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Scripture scripture = new Scripture();
        Reference reference= new Reference();
        Word words = new Word();
        reference.DisplayFullReference();
        // scripture.Display();
        words.DisplayWords();
    }


}