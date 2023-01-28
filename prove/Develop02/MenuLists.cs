using System;
using System.Collections.Generic;

public class MenuLists 
{
    public List<string> menuOpts = new List<string>()
    {
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit"
    };
    public void DisplayMenuOpts() 
    {
        for(int x = 0; x < menuOpts.Count; x++)
        {
            Console.WriteLine(menuOpts[x]);
        }
    }
    };

 
    public class Prompts
    {
        public List<string> entryPrompt = new List<string>()
    {
        "Write about an interaction you had with another person today.",
        "Write about a dream you had recently.",
        "Write about a tender mercy from the Lord you experienced today.",
        "Write about a scripture that stood out to you, and how it has influenced you.",
        "Write about a memory of a family member that you want to keep forever.",
        "Write about your daily routine.",
        "Write about your workplace, and your co-workers.",
        "Write about a time you felt the Lord answered a prayer differently than expected.",
        "Write about something you wish you would have known when you were younger.",
        "Write a piece of advice for your future self.",
        "Write about one thing you are particularly excited about.",
        "Write about a talent you have.",
        "Write about someone who you are grateful to have in your life.",
        "Write about something you wish you could change.",
        "Write about a friend you're no longer in touch with."
    };

    public void displayPrompts()
    {
        var random = new Random();
        int index = random.Next(entryPrompt.Count);
        Console.WriteLine(entryPrompt[index]);

    }
}

