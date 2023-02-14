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
        // words.isHidden = false;
        words.DisplayWords();
        Console.WriteLine("\n Hit enter to hide words, type quit to exit. \n");
        string action = Console.ReadLine();

        while (start == true)
        {
            Console.Clear();
            reference.DisplayFullReference();
            words.DisplayHidden();
            Console.WriteLine("\n Hit enter to hide words, type quit to exit. \n");
            action = Console.ReadLine();
            if (action != "quit" && words.isHidden == false)
            {
                start= true;
            }
            else if (action != "quit" && words.isHidden == true)
            {
                Console.WriteLine("Well done, you've memorized it!");
                start = false;
                break;
            }
            else 
            {
                start = false;
                break;
            }
        }

        
    }


}