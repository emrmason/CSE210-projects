using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeA = "You have an A. "; 
        string gradeB = "You have a B. ";
        string gradeC = "You have a C. ";
        string gradeD = "You have a D. ";
        string gradeF = "You have an F. ";
        string gradePass = "You have passed the course. Congratulations!";
        string gradeFail = "You have failed the course. Don't give up! Try again!";
        Console.WriteLine("What is your grade percentage? ");
        int percent = Convert.ToInt32(Console.ReadLine());

        if (percent >= 90)
        {
            Console.WriteLine($"{gradeA}{gradePass}");
        }
        else if (percent >= 80)
        {
            Console.WriteLine($"{gradeB}{gradePass}");
        }
        else if (percent >= 70)
        {
            Console.WriteLine($"{gradeC}{gradePass}");
        }
        else if (percent >= 60)
        {
            Console.WriteLine($"{gradeD}{gradeFail}");
        }
        else
        {
            Console.WriteLine($"{gradeF}{gradeFail}");
        }
    }
}