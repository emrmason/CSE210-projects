using System;

public class MathAssignment : Assignment
{
    protected string _textbookSection = "";
    protected string _problems = "";

    public void getMathAssignmment()
    {
        _textbookSection = "Ask your Instructor";
        _problems = "Ask your Instructor";
    }

    public string setMathAssignment(string textbookSection, string problems)
    {
        _textbookSection = textbookSection;
        _problems = problems;
        return $"{_studentName}, {_topic}, {_textbookSection} numbers {_problems}";
    }
}