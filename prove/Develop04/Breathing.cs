using System;

class Breathing : Activity
{
    string _welcomeMessage = "This activity is designed to focus on breathing in and out, relaxing your mind, \nand thinking only about your body and the breathing action.";

    // int counter = 5;
    
    public Breathing()
    {

    }

    public void startBreathing()
    {
        Timer breatheTime = new Timer();
        breatheTime.activityTime();
        int seconds = breatheTime._timeSet;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(breatheTime._timeSet);
        if(startTime < endTime)
        {
            for(int x = 0; x < breatheTime._timeSet;)
            {
            Console.Write($"Breathe in. . . ");
            Thread.Sleep(5000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            x = x+5;
            Console.Write("Breathe out. . .");
            Thread.Sleep(7000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            x = x+7;
            }
        
        Console.WriteLine($"Well done! You completed {seconds} seconds of the breathing activity.");
        Thread.Sleep(10000);
        }

    }


}