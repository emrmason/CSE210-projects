using System;

class Program
{
    static void Main(string[] args)
    {   
        bool runProg = true;

        while(runProg == true)
        {
            Menu menu = new Menu();
            Console.WriteLine("Welcome to the Mindfulness Program. Each activity is designed to help you \nslow down from the fast-paced world, and to think and feel deeply.\nPlease select from the following activities, or select 4 to quit.\n");
            menu.DisplayMenu();
            int activity = Int32.Parse(Console.ReadLine());

            if(activity == 1)
            {
                Timer startTime = new Timer();
                startTime.prepTime();
                Breathing breathing = new Breathing();
                breathing.startBreathing();

            }
            else if (activity == 2)
            {
                Timer startTime = new Timer();
                startTime.prepTime();
                Reflecting reflecting = new Reflecting();
                reflecting.startReflecting();

            }
            else if (activity == 3)
            {

            }
            else
            {
                runProg = false;
                break;
            }



        }


    }
}