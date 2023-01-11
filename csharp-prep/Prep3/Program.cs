using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("Please enter the magic number. ");
        int magicNumber = Int16.Parse(Console.ReadLine());

// Had help from a github user: https://gist.github.com/MrAwesomeness/6196354b6643faaad801  No code copied, just concepts used.

        while (guess != magicNumber)
        {
            Console.WriteLine("Guess the magic number: ");
            guess = Int16.Parse(Console.ReadLine());  

            if (guess > magicNumber)
            {
            Console.WriteLine("Try a lower number.");
            }

            else if (guess < magicNumber)
            {
            Console.WriteLine("Try a higher number.");
            }  

        }

        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it! Way to go!");
        }
}
}