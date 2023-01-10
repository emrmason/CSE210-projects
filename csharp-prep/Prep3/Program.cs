using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("Would you like to play? ");
        string play = Console.ReadLine();

        do {
        Console.WriteLine("Please enter the magic number. ");
        int magicNumber = Int16.Parse(Console.ReadLine());
        Console.WriteLine("Guess the magic number: ");
        int guess = Int16.Parse(Console.ReadLine());
        if (guess > magicNumber)
        {
            Console.WriteLine("Try a lower number. ");
            Console.ReadLine();
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Try a higher number. ");
            Console.ReadLine();

        }
        else
        {
            Console.WriteLine("You guessed it! ");

        }
        } while (play == "yes");
    }
}