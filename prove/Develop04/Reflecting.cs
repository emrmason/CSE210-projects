using System;

class Reflecting : Activity
{
    string _welcomeMessage = "This activity will help you reflect on times in your life when you have shown \nstrength and resilience. This will help you recognize the power you have and how you can use it \nin other aspects of your life.";

    List<string> startQuestions = new List<string>()
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you followed the promptings of the Holy Ghost."
    };

    List<string> refQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What did you learn from this experience that applies to other situations?",
        "What did you learn about yourself from this experience?",
        "How can you keep this experience in your mind in the future?"
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

            for(int x = 0; x < 5; x++)
            {
                var random2 = new Random();
                int index2 = random.Next(refQuestions.Count);
                string refQ = refQuestions[index];
                Console.WriteLine(refQ);
                Thread.Sleep(5000);
            }    

            Console.WriteLine($"Well done! You completed {seconds} seconds of the reflecting activity.\n\n\n");
            Thread.Sleep(10000);
        }

    }

}