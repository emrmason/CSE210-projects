using System;
using System.Collections.Generic;
using System.IO;

class Simple : Goal 
{
    //int x = 0;
    bool _isComplete = false;
    // string _type = "S";

public Simple()
{
    _type = "S";

}

public Simple(string name, string description, int pointVal, bool isComplete) 
{
    _type = "S";
    _name = name;
    _description = description;
    _pointVal = pointVal;
    _isComplete = isComplete;
    
}
public string getName()
{
    Console.WriteLine("\nWhat is the name of your goal? ");
    string name = Console.ReadLine();
    setName(name);
    return name;
}
public void setName(string name)
{
    _name = name;
}

public string getDesc()
{
    Console.WriteLine("\nWhat is a short description of your goal? ");
    string desc = Console.ReadLine();
    setDesc(desc);
    return desc;
}

public void setDesc(string desc)
{
    _description = desc;
}

public int getPoints()
{
    Console.WriteLine("\nHow many points is this goal worth? ");
    int points = Int32.Parse(Console.ReadLine());
    setPoints(points);
    return points;
}

public void setPoints(int points)
{
    _pointVal = points;
}



}