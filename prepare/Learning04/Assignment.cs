using System;

public class Assignment
{        
    protected string _studentName = "";
    protected string _topic = "";

    public void getAssignment()
    {
        _studentName = "No Name";
        _topic = "Some topic";
        
    }

    public string setAssignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
        return _studentName + _topic;
    }


}