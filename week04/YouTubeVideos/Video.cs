

using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _time;
    private List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, int time)
    {
        _title = title;
        _author = author;
        _time = time;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

   public List<Comment> GetComments()
   {
        return _comments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetTime()
    {
        return _time;
    }

    //public string Info()
    //{
    //    Console.WriteLine($"The info about this video: time: {GetTime}, author: {GetAuthor} and title of video:{GetTitle}");
    //    return "";
    //}

}