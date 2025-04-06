class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _eventLocation;

    public Event(string type, string title, string description, string date, string time, Address eventLocation)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _eventLocation = eventLocation;
    }

    public void PrintStandardDetails()
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Event Description: {_description}");
        Console.WriteLine($"Event Type: {_date}");
        Console.WriteLine($"Event Time: {_time}");
        Console.WriteLine($"Event Location: {_eventLocation}");
    }

    public void PrintShortDescription()
    {
        Console.WriteLine("Short Description:");
        Console.WriteLine($"Event Type: {_type}");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Event Type: {_date}");
    }

    public virtual void PrintFullDetails()
    {
        Console.WriteLine("Full Details");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Event Description: {_description}");
        Console.WriteLine($"Event Type: {_date}");
        Console.WriteLine($"Event Time: {_time}");
        Console.WriteLine($"Event Location: {_eventLocation}");

    }




}