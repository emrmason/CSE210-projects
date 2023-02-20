using System;

public class MathAssignment : Assignment
{
    protected string _textbookSection = "";
    protected string _problems = "";

    public MathAssignment(): base()
    {

    }
    public MathAssignment(string name, string topic, string section, string problems): base(name, topic)
    {
        // _textbookSection = section;
        // _problems = problems;
        // _studentName = name;
        // _topic = topic;
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

    public string getMathSummary(string name, string topic, string section, string problems)
    {
        _studentName = name;
        _topic = topic;
        _textbookSection = section;
        _problems = problems;
        return $"{name} - {topic}, {section} problems {problems}";
    }
}