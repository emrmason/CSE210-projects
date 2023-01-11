using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Console.WriteLine("Welcome to the number guessing game!");
        Console.WriteLine("Please enter the magic number. ");
        int magicNumber = Int16.Parse(Console.ReadLine());

        int i = 0;

// Had help from a github user: https://gist.github.com/MrAwesomeness/6196354b6643faaad801  No code copied, just concepts used.
// Learned that my guess write and readlines needed to be INSIDE the while loop in order for the user to be able to guess more than once.

        while (guess != magicNumber)
        {
            Console.WriteLine("Guess the magic number: ");
            guess = Int16.Parse(Console.ReadLine());  
            i++; 

            if (guess > magicNumber)
            {
            Console.WriteLine($"Try a lower number. This is guess {i}.");
            }

            else if (guess < magicNumber)
            {
            Console.WriteLine($"Try a higher number. This is guess {i}.");
            }  

        }

        if (guess == magicNumber)
        {
            Console.WriteLine($"You guessed it after {i} tries! Way to go!");
        }
}
}