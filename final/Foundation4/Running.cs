class Running : Activity
{

    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    public override double ReturnSpeed()
    {
        return (_distance / _duration) * 60;
        // Console.WriteLine($"Running Speed Is: {((_distance / _duration) * 60):F3} kilometers per hour");
    }

    public override double ReturnPace()
    {
        return _duration / _distance;
        // Console.WriteLine($"Running Pace is: {(_duration / _distance):F3} minutes per kilometer");
    }

    public override double ReturnDistance()
    {
        return _distance;
        // Console.WriteLine($"Running Distance is: {(_distance):F3} kilometers");
    }

    public override string GetSummary()
    {
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
        return $"{_date} Running ({_duration} min): Distance {ReturnDistance():F3} km, Speed: {ReturnSpeed():F3} kph, Pace: {ReturnSpeed():F3} min per km";
    }
}