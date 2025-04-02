class Swimming : Activity
{

    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _laps = laps;
    }

    public override void CalculateSpeed()
    {
        Console.WriteLine($"Swimming Speed is: {((_laps * .05)/_duration):F3} kilometers per hour");
    }

    public override void CalculatePace()
    {
        Console.WriteLine($"Swimming Pace is: {((_duration / (_laps * .05)) * 60):F3} minutes per kilometer");
    }

    public override void Distance()
    {
        Console.WriteLine($"Swimming Distance is: {(_laps * .05):F3} kilometers");
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} Swimming ({_duration} min): Distance {((_laps * .05)):F3} km, Speed: {((_laps * .05) / _duration):F3} kph, Pace: {((_duration / (_laps * .05)) * 60):F3} min per km");
    }
}