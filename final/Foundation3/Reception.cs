class Reception : Event
{
    private string _message;
    public Reception(string type, string title, string description, string date, string time, string message, Address eventLocation) : base(type, title, description, date, time, eventLocation)
    {
        _message = message;
        _eventLocation = eventLocation;
    }

    public override void PrintFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Event Description: {_description}");
        Console.WriteLine($"Event Date: {_date}");
        Console.WriteLine($"Event Time: {_time}");
        Console.WriteLine($"Event Location: {_eventLocation}");
        Console.WriteLine($"RSVP Email: {_message}");
    }

}