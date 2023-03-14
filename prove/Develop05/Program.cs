using System;
using System.Collections.Generic;
using System.IO;

class Program
{        


    static void Main(string[] args)
    {
        List<Goal> goalsList = new List<Goal>();
        // int x = 0;
        int points = 0;
        bool startGoals = true;
        Console.WriteLine($"\nYou have earned {points} points.");
        Console.WriteLine("\nWelcome to the Eternal Goals program. Please select from the following menu options: \n");

        while(startGoals == true)
        {
            Menu menu = new Menu();
            menu.displayMenu();
            Console.Write("\nEnter your selection: ");
            int choice = Int32.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Menu menu1 = new Menu();
                Console.WriteLine("\nWhat type of goal would you like to create? ");
                menu.displayGoalTypes();
                Console.Write("\nEnter your selection: ");
                int type = Int32.Parse(Console.ReadLine());

                if(type == 1)
                {
                    // int x = 1;
                    Simple goal1 = new Simple();
                    string name = goal1.promptName();
                    string desc = goal1.promptDesc();
                    int pointVal = goal1.promptPoints();
                    // string goal11 = goal1.ToString();
                    goalsList.Add(goal1);
                    // startGoals = true; 

                }
                if(type == 2)
                {
                    // x += 1;
                    Checklist goal2 = new Checklist();
                    string name = goal2.promptName();
                    string desc = goal2.promptDesc();
                    int pointVal = goal2.promptPoints();
                    int numEntries = goal2.promptEntries();
                    int numTillDone = numEntries;
                    goalsList.Add(goal2);
                    // startGoals = true;                    
                }
                if(type == 3)
                {
                    // x += 1;
                    Eternal goal3 = new Eternal();
                    string name = goal3.promptName();
                    string desc = goal3.promptDesc();
                    int pointVal = goal3.promptPoints();
                    goalsList.Add(goal3);
                    // startGoals = true;                    
                }
                // else
                // {
                //     Console.WriteLine("Please make a valid selection.");
                // }
                Console.WriteLine("\nMake another selection: ");
                startGoals = true;
            }

            if(choice == 2)
            {
                foreach(Goal Goal in goalsList)
                {
                    Goal glist = new Goal();
                    string name = Goal._name;
                    string desc = Goal._description;
                    int pworth = Goal._pointVal;
                    int numEntries = Goal._numEntries;
                    int numTillDone = Goal._numTillDone;
                    int x = 1;
                    if(Goal._type == "S")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points.");
                    }
                    else if(Goal._type == "C")
                    {
                        // int numEntries = Goal._numEntries;
                        // int numTillDone = Goal._numTillDone;
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points, {numEntries} / {numTillDone} completed.");
                    }
                    else if(Goal._type == "E")
                    {
                        Console.WriteLine($"{x++}. [ ] {name}, {desc}, worth {pworth} points. *Eternal*");
                    }
                }
                startGoals = true;
            }

            if(choice == 3)
            {
                Console.WriteLine("\nWhat filename should this save to? ");
                string fileName = (Console.ReadLine());
                int i = 1;
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Goal goal in goalsList)
                        {
                            if(goal._type == "S")
                            {
                                outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type}");
                            }
                            else if(goal._type == "C")
                            {
                                outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type} | {goal._numEntries} / {goal._numTillDone} completed.");
                            }
                            else if(goal._type == "E")
                            {
                                outputFile.WriteLine($"{i++}. |[ ] | {goal._name}, | {goal._description}, | worth {goal._pointVal} points | {goal._type}");
                            } 
                            else 
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                        }
                    }

                startGoals = true;
            }

            if(choice == 4)
            {
                    Console.WriteLine("Enter the filename to be opened: ");
                    string filename = (Console.ReadLine());
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    Goal goal4 = new Goal();

                    foreach(string line in lines)
                    {
                        string[] parts = line.Split("|");
                        goal4._name = parts[0];
                        goal4._description = parts [1];
                        goal4._pointVal = Int32.Parse(parts [2]);
                        goal4._isComplete = bool.Parse(parts [3]);
                        goal4._type = parts[4];
                        goal4._numEntries = Int32.Parse(parts[6]);
                        goal4._numTillDone = Int32.Parse(parts[5]);
                        goalsList.Add(goal4);
                        // if(goal4._type == "S")
                        // {
                        //     goalsList.Add(goal4);
                        // }
                        // if(goal4._type == "C")
                        // {
                        //     goalsList.Add(goal4);
                        // }
                        // if(goal4._type == "E")
                        // {
                        //     goalsList.Add(goal4);
                        // }
                        // else
                        // {
                        //     Console.WriteLine("Error.");
                        //     break;
                        // }
            }
            }

            if(choice == 5)
            {
                Console.WriteLine("Which goal are you recording?");
                int goalNum = Int32.Parse(Console.ReadLine());

                startGoals = true;
            }

            if(choice == 6)
            {
                Console.WriteLine("Well done for working on your goals!");
                startGoals = false;
                //Console.Clear;
            }
            // else
            // {
            //     Console.WriteLine("\nPlease make a valid selection from the list. \n");
            //     startGoals = true;
            // }

        }
    }
}    
