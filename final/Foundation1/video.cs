using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public List<Comment> Comments
    {
        get { return _comments; }
        set { _comments = value; }
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        _comments.Add(comment);
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length + " seconds");
        Console.WriteLine("Number of comments: " + GetNumComments());
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(" - " + comment.CommenterName + ": " + comment.Text);
        }
    }
}
