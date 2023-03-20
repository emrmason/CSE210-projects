using System;
using System.Collections;

class Comment
{
    protected string _vidTitle;
    protected string _commentor;
    protected string _comment;

    List<Comment> comments = new List<Comment>();

public Comment()
{

}

public Comment(string title, string commentor, string comment)
{
    _vidTitle = title;
    _commentor = commentor;
    _comment = comment;
    string newComment = $"{_vidTitle}, {_commentor} says: {_comment}";
    Console.WriteLine($"Comment author {commentor} says: {comment}");
    comments.Add(newComment);
}

public string getTitle()
{
    Video video1 = new Video();
    video1._title = _vidTitle;
    return _vidTitle;
}

public string getComment()
{
    Console.WriteLine("Comment by: ");
    _commentor = Console.ReadLine();
    Console.WriteLine("Comment: ");
    _comment = Console.ReadLine();
    return _comment;

}


}