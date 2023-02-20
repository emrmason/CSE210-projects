using System;

public class Assignment
{     
    protected string _studentName = "";
    protected string _topic = "";

    public Assignment()
    {
        
    }
    public Assignment(string studentName, string topic)
    {   
        _studentName = studentName;
        _topic = topic;
    }

    public string getAssignment()
    {
        return $"{_studentName} - {_topic} ";
        
    }

    public string getAssignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
        return _studentName + _topic;
    }
    public string getSummary(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
        return $"{name} - {topic} ";
    }
    
}