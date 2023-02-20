using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment();
        Console.WriteLine(assign1.getSummary("Claire", "Metaphors"));

        MathAssignment math1 = new MathAssignment();
        Console.WriteLine(math1.getMathSummary("Ben", "Algebra", "Lesson 5.3", "15-45 odd"));
        Console.WriteLine(math1.getAssignment("Jack", "Trigonometry"));

        WritingAssignment write1 = new WritingAssignment();
        Console.WriteLine(write1.getWritingSummary("Stacey", "WWII", "Propaganda Uses"));

    }
}