using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<Comment> comments = new List<Comment>();

        Video video1 = new Video("Fungus Among Us", "Obi-Wan Kenobi", 605);
        videos.Add(video1);

        Video video2 = new Video("James and Lily Potter", "JK Rowling", 1292);
        videos.Add(video2);

        Video video3 = new Video("Joseph Smith - Boyhood", "Jane Doe", 1523);
        videos.Add(video3);

        Video video4 = new Video("Take a Chance", "ABBA", 452);
        videos.Add(video4);

        Comment comment1 = new Comment("Fungus Among Us", "She-Ra", "This movie is the best study in mushrooms we've seen in ages!");
        comments.Add(comment1);

        Comment comment2 = new Comment("James and Lily Potter", "He-Man", "I've been waiting for this story for 20 years!!");
        comments.Add(comment2);
        
        Comment comment3 = new Comment("Joseph Smith - Boyhood", "Chili Palmer", "I never expected him to be so... human. ");
        comments.Add(comment3);

        Comment comment4 = new Comment("Fungus Among Us", "Shelly Long", "Mushrooms are super gross. ");
        comments.Add(comment4);

        foreach(Video video in videos)
        {
            int x = 0;
            string title = video._title;
            string author = video._author;
            int length = video._length;
            foreach(Comment comment in comments)
            {
                if(video._title == comment._vidTitle)
                {
                    x += 1;
                }
            }    
            Console.WriteLine($"Title: {title}, By: {author}, Length: {length} seconds, Comments: {x} ");
        }
    }
}