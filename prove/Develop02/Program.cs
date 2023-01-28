using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal program! What would you like to do?");
        MenuLists Menu1 = new MenuLists();
        Menu1.DisplayMenuOpts();
        string menuChoice = Console.ReadLine();

            if (menuChoice == "1") {
                journalEntry entry1;
                entry1 = new journalEntry();
                // Console.WriteLine("Enter today's date: ");
                // entry1._date = Console.ReadLine(); Generate the date!!
                //Console.WriteLine("Here is your prompt: ");
                string date = DateTime.UtcNow.ToString("MM/dd/yyyy");
                Prompts Prompt1 = new Prompts();
                Prompt1.displayPrompts();
                // Console.WriteLine("Write away!");
                entry1._entry = Console.ReadLine();
                entry1._jentries.Add($"{entry1._date}\r\n {entry1._prompt}\r\n {entry1._entry}");
            }

            else if (menuChoice == "2") {
                journalEntry entry;
                entry = new journalEntry();
                entry.DisplayJournal();
            }
        }

        }  


