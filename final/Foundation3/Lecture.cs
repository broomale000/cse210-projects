class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string type, string title, string description, string date, string time, string speaker, int capacity, Address eventLocation) : base(type, title, description, date, time, eventLocation)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventLocation = eventLocation;
    }

    public override void PrintFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Event Description: {_description}");
        Console.WriteLine($"Event Type: {_date}");
        Console.WriteLine($"Event Time: {_time}");
        Console.WriteLine($"Event Location: {_eventLocation}");
        Console.WriteLine($"Event Speaker: {_speaker}");
        Console.WriteLine($"Event Capacity: {_capacity}");
    }
}