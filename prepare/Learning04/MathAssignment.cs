using System;

public class MathAssignment : Assignment
{
    protected string _textbookSection = "";
    protected string _problems = "";

    // public MathAssignment(): base()
    // {
    //     string name = _studentName;
    //     string topic = _topic;
    //     string assignedSection = _textbookSection;
    //     string assignedProblems = _problems;
    // }
    public MathAssignment(): base()
    {
        string section = _textbookSection;
        string problems = _problems;
        string name = _studentName;
        string topic = _topic;
    }     

  
    public string getMathAssignmment(string section, string problems)
    {
        string name = _studentName;
        string topic = _topic;
        _textbookSection = section;
        _problems = problems;
        return $"{name} - {topic}, {section} numbers {problems}";
    }

    public void setMathAssignment(string section, string problems)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string getMathSummary()
    {
        string name = _studentName;
        string topic = _topic;
        string section = _textbookSection;
        string problems = _problems;
        return $"{name} - {topic}, {section} problems {problems}";
    }
}