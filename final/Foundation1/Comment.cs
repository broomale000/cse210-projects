
class Comment
{
    protected string _username;
    protected string _comment;

    public Comment(string name, string message)
    {
        _username = name;
        _comment = message;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_username} replied:\n{_comment}");
    }
}