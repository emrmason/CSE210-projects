using System;
using System.Collections.Generic;
using System.IO;

class Goal
{
    // int x = 0;
    public string _type;
    public string _name;
    public string _description;
    public int _pointVal;
    public int _numEntries;
    public int _numTillDone;
    public bool _isComplete;
    public int _pointsEarned;
    // string _checkBox;
    // string _checkedOff;
    // https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-of-objects-in-C-Sharp/

    public Goal()
    {

    }

    public Goal(string name, string description, int pointVal, bool isComplete, int numEntries, int numTillDone)
    {
        _name = name;
        _description = description;
        _pointVal = pointVal;
        _isComplete = false;
        _numEntries = numEntries;
        _numTillDone = numTillDone;

    }


    public string promptName()
    {
        Console.WriteLine("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        _name = name;
        return _name;
    }


    public string promptDesc()
    {
        Console.WriteLine("\nWhat is a short description of your goal? ");
        string description = Console.ReadLine();
        _description = description;
        return _description;
    }


    public int promptPoints()
    {
        Console.WriteLine("\nHow many points will this goal be worth?");
        int points = Int32.Parse(Console.ReadLine());
        _pointVal = points;
        return _pointVal;
    }

    public void fileToList()
    {
        Console.WriteLine("Enter the filename to be opened: ");
        string filename = (Console.ReadLine());
        string[] lines = System.IO.File.ReadAllLines(filename);
            foreach(string line in lines)
            {
                string[] parts = line.Split("|");
                _name = parts[0];
                _description = parts [1];
                _pointVal = Int32.Parse(parts [2]);
                _isComplete = bool.Parse(parts [3]);
                _type = parts[4];
                _numEntries = Int32.Parse(parts[5]);
                _numTillDone = Int32.Parse(parts[6]);
                if(_type == "S")
                {
                    
                }
            }
    }


}