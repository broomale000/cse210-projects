class Gathering : Event
{
    private string _forecast;
    public Gathering(string type, string title, string description, string date, string time, string forecast, Address eventLocation) : base(type, title, description, date, time, eventLocation)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _forecast = forecast;
        _eventLocation = eventLocation;
    }

    public override void FullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Event Description: {_description}");
        Console.WriteLine($"Event Type: {_date}");
        Console.WriteLine($"Event Time: {_time}");
        Console.WriteLine($"Event Location: {_eventLocation}");
        Console.WriteLine($"Event Speaker: {_forecast}");
    }
}