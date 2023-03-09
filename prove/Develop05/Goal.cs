using System;
using System.Collections.Generic;

class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointVal;
    protected bool _isComplete;
    protected string _checkBox = "[ ]";
    protected string _checkedOff = "[X]";
    // https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-of-objects-in-C-Sharp/
    public List<Goal> goals = new List<Goal>();

    public Goal()
    {

    }

    public void SetGoal(string name, string description, int points, bool isComplete)
    {
        name = _name;
        description = _description;
        points = _pointVal;
        isComplete = false;
    }

    public void CreateGoal(string name, string description, int points, bool isComplete)
    {
        // goals.Add("")

    }


}