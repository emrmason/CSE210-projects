using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment();
        Console.WriteLine(assign1.getSummary("Claire", "Algebra"));

        MathAssignment math1 = new MathAssignment();
        math1.setMathAssignment("Lesson 5.2", "11-25 odd");
        Console.WriteLine(math1.getMathSummary());

    }
}