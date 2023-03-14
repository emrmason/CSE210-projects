using System;
using System.Collections.Generic;
using System.IO;

class Checklist : Goal
{
    int x = 0;
    bool isComplete = false;
    int numEntries = 0;
    int numTillDone = 0;

    public Checklist()
    {

    }

//     public string getName()
// {
//     Console.WriteLine("\nWhat is the name of your goal? ");
//     string name = Console.ReadLine();
//     setName(name);
//     return name;
// }
// public void setName(string name)
// {
//     _name = name;
// }

// public string getDesc()
// {
//     Console.WriteLine("\nWhat is a short description of your goal? ");
//     string desc = Console.ReadLine();
//     setDesc(desc);
//     return desc;
// }

// public void setDesc(string desc)
// {
//     _description = desc;
// }

// public int promptPoints()
// {
//     Console.WriteLine("\nHow many points is this goal worth? ");
//     int points = Int32.Parse(Console.ReadLine());
//     setPoints(points);
//     return points;
// }

// public void setPoints(int points)
// {
//     _pointVal = points;
// }

public int promptEntries()
{
    Console.WriteLine("\nHow many times until this goal is complete? ");
    int numEntries = Int32.Parse(Console.ReadLine());
    _numEntries = numEntries;
    return _numEntries;

}

// public void setEntries(int numEntries)
// {
//     _numEntries = numEntries;
// }
}