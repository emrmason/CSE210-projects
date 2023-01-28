using System;
using System.Collections.Generic;

public class JEntry
{
    public string _date = "";
    public string _prompt = "";
    public string _words = "";
    public JEntry() {

    }
    // public void NewEntry (string date; string prompt; string words)
    // {
    //     _date = date;
    //     _prompt = prompt;
    //     _words = words;
    //     NewEntry = Console.WriteLine($"Date: {_date}, Prompt: {_prompt}, Entry: {_words}");
    //     entries.Add(newEntry);
    //     return newEntry ;
    // }
    

    public List<string> entries = new List<string> {

    };
}

    
