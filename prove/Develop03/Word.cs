using System;
using System.Collections;

class Word
{    
    private static string scripture = "35. O, remember, my son, and learn wisdom in thy youth; yea, learn in they youth to keep the commandments of God.\n36. Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever.\n37. Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";

    
    
    // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
        public string[] separateWords = scripture.Split(' ');

        public void DisplayWords()
        {
            foreach(string i in separateWords)
            {
                Console.WriteLine(i);
            }
        }
    
}