using System;
using System.Collections;

class Comment
{
    public string _vidTitle;
    public string _commentor;
    public string _comment;


public Comment()
{

}

public Comment(string title, string commentor, string comment)
{
    _vidTitle = title;
    _commentor = commentor;
    _comment = comment;
    // string newComment = $"{_vidTitle}, {_commentor} says: {_comment}";
    // Console.WriteLine($"Comment author {commentor} says: {comment}");
}

// public string getTitle()
// {
//     Video video1 = new Video();
//     video1._title = _vidTitle;
//     return _vidTitle;
// }

// In case I want the user to be able to enter comments...
public string newComment()
{
    Console.WriteLine("Comment by: ");
    _commentor = Console.ReadLine();
    Console.WriteLine("Comment: ");
    _comment = Console.ReadLine();
    return "";

}


}