using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        //
    }

    public Assignment(string name, string subject)
    {
        _studentName = name;
        _topic = subject;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}