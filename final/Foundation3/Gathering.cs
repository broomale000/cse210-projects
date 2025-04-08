class Gathering : Event
{
    private string _forecast;
    public Gathering(string type, string title, string description, string date, string time, string forecast, Address eventLocation) : base(type, title, description, date, time, eventLocation)
    {
        _forecast = forecast;
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
        Console.WriteLine($"Forecast: {_forecast}");
    }
}