using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Fungus Among Us", "Obi-Wan Kenobi", 600);
        videos.Add(video1);

        foreach(Video video in videos)
        {
            string title = video._title;
            string author = video._author;
            int length = video._length;
            Console.WriteLine($"Title: {title}, By: {author}, Length: {length} seconds ");
        }
    }
}