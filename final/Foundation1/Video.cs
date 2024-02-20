using System.Globalization;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _length = lengthSeconds;
    }

    public int GetNumberOfComments(List<Comment> comments)
    {
        int number = comments.Count;

        return number;
    }

    public void Display()
    {
        Console.WriteLine($"{_title} -- {_author} (Duration: {_length} seconds)");
        Console.WriteLine($"{GetNumberOfComments(_comments)} Comments:");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}