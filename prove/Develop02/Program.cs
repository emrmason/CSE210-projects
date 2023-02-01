using System;
using System.Collections.Generic;
using System.IO;

class Program
{

    static void Main(string[] args)
{
    bool start = true;
    // Thank you, Eric C from the tutoring resources! 
    List<string> entries = new List<string>()
    {   
    };

    while (start == true){
        Menu menu1 = new Menu();
        Console.WriteLine("Welcome to the Journal Program. What would you like to do?");
        menu1.DisplayMenuOpts();
        string userChoice = Console.ReadLine();

    if (userChoice == "1") {
        string date = DateTime.UtcNow.ToString("MM/dd/yyyy"); 
        string prompt = displayPrompt();
        Console.Write($"{prompt}\n>");
        string text = Console.ReadLine();
        string anEntry = ($"{date}, {prompt}, {text}");
        Journal entry1 = new Journal(date, prompt, text);
        entries.Add($"{date}, {prompt}, {text}");
    }

    else if (userChoice == "2") {
        foreach(string entry in entries){

            Console.WriteLine(entry);
        }
    }

    else if (userChoice == "3"){
        Console.Write("Enter a filename to load from, .txt: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
            Console.WriteLine($"Date: {date}, Prompt: {prompt} Entry: {text}");
        }
    }

    else if (userChoice == "4"){
        Console.Write("Enter a filename to save to, .txt: ");
        string filename = Console.ReadLine();
        foreach(string entry in entries)
        {
            System.IO.File.WriteAllText(filename, entry);
        };
    }
    else if (userChoice == "5") {
        Console.WriteLine("Thank you, goodbye.");
        start = false;
    }
    }

}



    static List<string> prompt = new List<string>()
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

    static string displayPrompt()
    {
        var random = new Random();
        int index = random.Next(prompt.Count);
        string randomPrompt = prompt[index];
        return randomPrompt;

    } 
    }



