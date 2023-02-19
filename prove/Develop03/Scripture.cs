using System;
using System.Collections;

class Scripture
{
    private static string _scripture = "35. O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.\n36. Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever.\n37. Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";
    // private string _reference = "Alma 37:35-37";     // 140 words, including verse numbers. TODO: random number generator, with NO REPEATS.
    // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
       
        // do I need to build a list to index the numbers that have already been generated?
        // could i remove the index number from a list of random numbers to prevent repetition?
    public string[] separateWords = _scripture.Split(' ');
    public List<int> separateWordsIndex = new List<int>();

    public void Display()
    {
        Console.WriteLine($"{_scripture}");
    }

    public void DisplayScripture()
    {
        foreach(string i in separateWords)
        {
            Console.Write($"{i} ");
        }
    }

    // public void indexWords()
    // {
    //     for(int t=0; t < 141; t++)
    //     {
    //         separateWordsIndex.Add(t);
    //     }
    // }

    // public int randNumber()
    // {
    //     int z = 0;
    //     for(int y = 0; y < 3;)
    //     {
    //     Random n = new Random();
    //     z = n.Next(0, 140);
    //     y++;
    //     }
    //     separateWordsIndex.Remove(z);
    //     return z;
    // }

    public void DisplayHidden()
    {
        string hiddenWords = " _____ ";
        int y = separateWords.Length;           
        Random i = new Random();
        int w = i.Next(0, y);
            if(separateWordsIndex.Contains(w))
            {
                Random n = new Random();
                int v = i.Next(0,y);
                separateWords[v] = hiddenWords;
                separateWordsIndex.Add(v);
            }
            else
            {
                separateWords[w] = hiddenWords;
                separateWordsIndex.Add(w);
            }
            
        foreach(string z in separateWords)
        {
            Console.Write($" {z}");
        }
        }

}