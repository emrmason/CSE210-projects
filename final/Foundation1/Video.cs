using System;
using System.Collections;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public int _numComments;

    // public List<Comment> comments = new List<Comment>();

    public Video()
    {

    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        // videos.Add(Video);
    }

    // In case I want the user to be able to add a new video...
    public string NewVid()
    {
        Console.WriteLine("What is the video title?");
        string _title = Console.ReadLine();
        Console.WriteLine("Who is the author of the video?");
        string _author = Console.ReadLine();
        Console.WriteLine("How long (in seconds)is the video?");
        int _length = Int32.Parse(Console.ReadLine());
        return "";
    }


}