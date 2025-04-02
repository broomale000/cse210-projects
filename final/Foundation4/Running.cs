class Running : Activity
{

    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    public override void CalculateSpeed()
    {
        Console.WriteLine($"Running Speed Is: {((_distance / _duration) * 60):F3} kilometers per hour");
    }

    public override void CalculatePace()
    {
        Console.WriteLine($"Running Pace is: {(_duration / _distance):F3} minutes per kilometer");
    }

    public override void Distance()
    {
        Console.WriteLine($"Running Distance is: {(_distance):F3} kilometers");
    }

    public override void GetSummary()
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
        Console.WriteLine($"{_date} Running ({_duration} min): Distance {(_distance):F3} km, Speed: {((_distance / _duration) * 60):F3} kph, Pace: {(_duration / _distance):F3} min per km");
    }
}