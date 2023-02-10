using System;

class Program
{
    static void Main(string[] args)
    {

        bool start = true;
        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Scripture scripture = new Scripture();
        Reference reference= new Reference();
        Word words = new Word();
        reference.DisplayFullReference();
        // scripture.Display();
        words.DisplayWords();
        Console.WriteLine("\n Hit enter to hide words, type quit to exit. \n");
        string action = Console.ReadLine();

        while (start == true)
        {
            Console.Clear();
            words.DisplayHidden();
            Console.WriteLine("\n Hit enter to hide words, type quit to exit. \n");
            action = Console.ReadLine();
            if (action != "quit")
            {
                start= true;
            }
            else 
            {
                start = false;
                break;
            }
        }

        
    }


}