using System;

public class MathAssignment : Assignment
{
    protected string _textbookSection = "";
    protected string _problems = "";

    public MathAssignment(): base()
    {
        string name = _studentName;
        string topic = _topic;
        string assignedSection = _textbookSection;
        string assignedProblems = _problems;
    }
    public MathAssignment(string section, string problems)
    {
        _textbookSection = section;
        _problems = problems;

    }     

    // public void getMathAssignment()
    // {
    //     _textbookSection = "Lesson 5.0";
    //     _problems = "#12 - 30";
    // }   
    public string getMathAssignmment(string section, string problems)
    {
        string name = _studentName;
        string topic = _topic;
        section = _textbookSection;
        problems = _problems;
        return $"{name} - {topic}, {section} numbers {problems}";
    }
    // public string getMathAssignment()
    // {
    //     return $"{_textbookSection}, {_problems}";
    // }

    public void setMathAssignment(string section, string problems)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string getMathSummary() : base(getSummary(string name, string topic))
    {
        string name = _studentName;
        string topic = _topic;
        string section = _textbookSection;
        string problems = _problems;
        return $"{name} - {topic}, {section} problems {problems}";
    }
}