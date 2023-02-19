using System;
using System.Collections;

class Word
{    
    public bool isHidden = false;    
    
    Scripture word = new Scripture();

    // public string hideWord()
    // {
    //     for(int xy=0; xy<3; xy++)
    //     {
    //         int z = word.separateWordsIndex[];
    //         string eachWord = word.separateWords[z];
    //         string newWord = "_____";
    //         eachWord = newWord;
    //         isHidden = true;
    //     }
    //     string nothing = "nothing";
    //     Console.Write(word);
    //     return nothing;
    // }


        // public void DisplayHidden()
        // {
        //     string hiddenWords = " _____ ";
        //     int y = separateWords.Length;           
        //     Random i = new Random();
        //     int w = i.Next(0, y);
        //         if(separateWordsIndex.Contains(w))
        //         {
        //             Random n = new Random();
        //             int v = i.Next(0,y);
        //             separateWords[v] = hiddenWords;
        //             separateWordsIndex.Add(v);
        //         }
        //         else
        //         {
        //             separateWords[w] = hiddenWords;
        //             separateWordsIndex.Add(w);
        //         }
            
        //     foreach(string z in separateWords)
        //     {
        //         Console.Write($" {z}");
        //     }
        // }

        // public void IsHidden()
        // {
        //     if(separateWordsIndex.Count == 140)
        //     {
        //         isHidden = true;
        //     }
        //     else
        //     {
        //         isHidden = false;
        //     }
        // }
}