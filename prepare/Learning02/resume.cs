using System;
using System.Collections.Generic;

public class Resume
{
    public string _name = "";
    public List<string> jobs = new List<string>();


public void DisplayResume()
{
    Console.WriteLine($"Name: {_name} \r\nJobs: \r\n   {jobs[0]} \r\n   {jobs[1]}");
}
}