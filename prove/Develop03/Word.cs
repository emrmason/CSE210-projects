using System;
using System.Collections;

class Word
{    
    // 140 words, including verse numbers. TODO: random number generator, with NO REPEATS.
    private static string scripture = "35. O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.\n36. Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever.\n37. Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";

    public bool isHidden = false;    
    
    // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
        public string[] separateWords = scripture.Split(' ');
        
        // do I need to build a list to index the numbers that have already been generated?
        // could i remove the index number from a list of random numbers to prevent repetition?
        public List<int> separateWordsIndex = new List<int>();
        public void DisplayWords()
        {
            foreach(string i in separateWords)
            {
                Console.Write($"{i} ");
            }
        }
    
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

        public void IsHidden()
        {
            if(separateWordsIndex.Count == 140)
            {
                isHidden = true;
            }
            else
            {
                isHidden = false;
            }
        }
}