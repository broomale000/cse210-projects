
class Video
{
    private string _title;
    private string _author;
    private string _date;
    private int _length;

    List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, string date, int length)
    {
        _title = title;
        _author = author;
        _date = date;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayAll()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nDate: {_date}\nLength: {_length} seconds");
        CountComments();
        Console.WriteLine();
        
        foreach (Comment comment in Comments)
        {
            comment.Display();
            Console.WriteLine();
        }
        
        Console.WriteLine("-----------------------------------------");
    }

    public void CountComments()
    {
        Console.WriteLine($"Nummber of replies: " + Comments.Count);
    }

}