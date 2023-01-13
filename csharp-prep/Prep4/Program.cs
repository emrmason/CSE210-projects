using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int newEntry = Int16.Parse(Console.ReadLine());
   
        while (newEntry != 0)
        {        
            numbers.Add(newEntry);
            Console.WriteLine("Enter another number:");
            newEntry = Int16.Parse(Console.ReadLine());
        }
        
        if (newEntry == 0)
        {
            double summation = numbers.Sum();
            double avg1 = numbers.Average();
            double max1 = numbers.Max();
            double min1 = numbers.Min();
            Console.WriteLine($"The sum of your list is: {summation}. The average of your list is: {avg1}."); 
            Console.WriteLine($"The highest value you provided is: {max1}. The lowest value you provided is: {min1}.");
        }
    }
}