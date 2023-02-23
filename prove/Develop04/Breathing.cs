using System;

class Breathing : Activity
{
    string _welcomeMessage = "\nThis activity is designed to focus on breathing in and out, relaxing your mind, \nand thinking only about your body and the breathing action.\n \n";

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

                Console.Write("< < Breathe in .");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . \n \n");
                Thread.Sleep(1000);
                x++;

                Console.Write("> > > Breathe out.");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;
                Console.Write(" . ");
                Thread.Sleep(1000);
                x++;                                                                                                
            }
        
        Console.WriteLine($"Well done! You completed {seconds} seconds of the breathing activity.\n\n\n");
        Thread.Sleep(5000);
        }

    }


}