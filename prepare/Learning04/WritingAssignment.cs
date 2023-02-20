using System;

public class WritingAssignment : Assignment
{
    protected string _title = "";

    public void getTitle()
    {
        _title = "Tell about your day.";
    }

    public string setTitle(string title)
    {
        _title = title;
        return $"{_studentName}, {_topic}, {_title}";

    }

}