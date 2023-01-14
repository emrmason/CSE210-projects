using System;

class Program
{
    static void Main(string[] args)
    {
        {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqNumber = SquareNumber(favNumber);

        DisplayResult(userName, sqNumber);

        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the C# Prep 5 Program!");
        }

        static string PromptUserName() 
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
            
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int favNumber = Int16.Parse(Console.ReadLine());
            return favNumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {square}.");
        }
    }
}