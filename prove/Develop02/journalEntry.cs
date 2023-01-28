using System;
using System.Collections.Generic;

public class journalEntry 
{
    //public string _date = "";
    public string _prompt = "";
    public string _entry = "";
    public List<string> _jentries = new List<string>();
    public void DisplayJournal() {
        for(int x = 0; x<_jentries.Count; x++) {
            Console.WriteLine(_jentries[x]);
        }
    }

    

}