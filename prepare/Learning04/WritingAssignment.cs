using System;

public class WritingAssignment : Assignment
{
    protected string _title = "";

    public WritingAssignment(): base()
    {
        string name = _studentName;
        string topic = _topic;
        string assignedTitle = _title;

    }

    public string getWritingSummary(string name, string topic, string title)
    {
        _title = title;
        _studentName = name;
        _topic = topic;
        return $"{topic}, {title} by {name}";

    }
    public void getTitle()
    {
        _title = "Why Birds are Awesome";
    }

    public string setTitle(string title)
    {
        _title = title;
        return $"{_studentName}, {_topic}, {_title}";

    }

}