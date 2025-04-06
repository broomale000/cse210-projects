class Swimming : Activity
{

    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _laps = laps;
    }

    public override double ReturnSpeed()
    {
        return (_laps * .05) / _duration * 60;
        // Console.WriteLine($"Swimming Speed is: {((_laps * .05)/_duration):F3} kilometers per hour");
    }

    public override double ReturnPace()
    {
        return (_duration / (_laps * .05)) * 60;
        // Console.WriteLine($"Swimming Pace is: {((_duration / (_laps * .05)) * 60):F3} minutes per kilometer");
    }

    public override double ReturnDistance()
    {
        return _laps * .05;
        // Console.WriteLine($"Swimming Distance is: {(_laps * .05):F3} kilometers");
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_duration} min): Distance {ReturnDistance():F3} km, Speed: {ReturnSpeed():F3} kph, Pace: {ReturnPace():F3} min per km";
    }
}