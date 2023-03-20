using System;
using System.Collections;

class Video
{
    public string _title;
    string _author;
    int _length;
    int _numComments;

    List<Video> videos = new List<Video>();

    public Video()
    {

    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        videos.Add(Video);
    }


}