
using System.Diagnostics.Metrics;

class Listing : Activity{

    private List<string> _prompts = new List<string>()
    {
        "-- Who are people that you appreciate? --",
        "-- What are personal strengths of yours? --",
        "-- Who are people that you have helped this week? --",
        "-- When have you felt the Holy Ghost this month? --",
        "-- Who are some of your personal heroes? --"
    };

    private Random _random = new Random();
    private int _listedItems = 0;
    
    public void ListingIntro()
    {
        Intro("Listing Activity. ", "reflect on the good things in your life by having you list as many things as you can in a certain area. ");
        _activityType = "Listing";
    }

    public void RepeatEnter(string _string)
    {
        Console.Write("> ");
        _listedItems = _listedItems + 1;
    }

    public void ListOut()
    {
        GetReady(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can for the following prompt:");
        int _index = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[_index]);
        Console.WriteLine("You may begin in: ");
        Countdown(5);
        Console.Write("> ");

        DateTime _startTime = DateTime.Now;
        DateTime _futureTime = _startTime.AddSeconds(_sessionDuration);

        while (DateTime.Now < _futureTime)
        {
            string _string = Console.ReadLine();
            RepeatEnter(_string);
        }

        Console.WriteLine($"You listed {_listedItems} items!");
        Console.WriteLine("\nWell done!");
        DisplayDuration(_sessionDuration, _activityType);
        Pause(5);
        Console.Clear();

    }

}