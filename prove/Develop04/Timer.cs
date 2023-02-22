using System;

class Timer
{
    public Timer()
    {

    }
    protected int _timeSet;
    protected string _timeRequested = "How long would you like to do this activity? ";
    protected string _getReady = "Prepare to begin. . . ";

    public int getTime()
    {
        Console.WriteLine(_timeRequested);
        _timeSet = Int32.Parse(Console.ReadLine());
        return _timeSet;
    }

    public void prepTime()
    {
        Console.WriteLine(_getReady);
        for(int x = 0; x < 5; x++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

}