using System;

class Reflecting : Activity
{
    string _welcomeMessage = "\nThis activity will help you reflect on times in your life when you have shown \nstrength and resilience. This will help you recognize the power you have and how you can use it \nin other aspects of your life.\n \n";

    List<string> startQuestions = new List<string>()
    {
        "> Think of a time when you stood up for someone.\n \n",
        "> Think of a time when you did something really difficult.\n \n",
        "> Think of a time when you helped someone in need.\n \n",
        "> Think of a time when you did something truly selfless.\n \n",
        "> Think of a time when you followed the promptings of the Holy Ghost.\n \n"
    };

    List<string> refQuestions = new List<string>()
    {
        "> Why was this experience meaningful to you?\n> \n> \n",
        "> Have you ever done anything like this before?\n> \n> \n",
        "> How did you get started?\n> \n> \n",
        "> How did you feel when it was complete?\n> \n> \n",
        "> What made this time different than other times when you were not as successful?\n> \n> \n",
        "> What is your favorite thing about this experience?\n> \n> \n",
        "> What did you learn from this experience that applies to other situations?\n> \n> \n",
        "> What did you learn about yourself from this experience?\n> \n> \n",
        "> How can you keep this experience in your mind in the future?\n> \n> \n"
    };
    public Reflecting()
    {

    }

    public void startReflecting()
    {
        Console.WriteLine(_welcomeMessage);
        Timer refTime = new Timer();
        refTime.activityTime();
        int seconds = refTime._timeSet;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(refTime._timeSet);
        if(startTime < endTime)
        {
            var random = new Random();
            int index = random.Next(startQuestions.Count);
            string startQ = startQuestions[index];
            Console.WriteLine(startQ);
            Thread.Sleep(10000);
            // int x = 0;
            // This loop keeps giving me the same question to answer... How do I fix that? SOLVED -- I didn't change the index# on the second and third random requests...

            // I suspect that this thread overrides the time sequencing... How do I fix that?
            for(int x = 10; x < refTime._timeSet;)
            {
                var random2 = new Random();
                int index2 = random.Next(refQuestions.Count);
                string refQ = refQuestions[index2];
                Console.WriteLine(refQ);
                Thread.Sleep(10000);
                x = x+10;

                var random3 = new Random();
                int index3 = random.Next(refQuestions.Count);
                string refQ2 = refQuestions[index3];
                Console.WriteLine(refQ2);
                Thread.Sleep(10000);
                x = x+10;

                var random4 = new Random();
                int index4 = random.Next(refQuestions.Count);
                string refQ3 = refQuestions[index4];
                Console.WriteLine(refQ3);
                Thread.Sleep(10000);
                x = x+10;

            }
        }    

            Console.WriteLine($"Well done! You completed {seconds} seconds of the reflecting activity.\n\n\n");
            Thread.Sleep(10000);
    }

}