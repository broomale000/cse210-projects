class Cycling : Activity
{

    private double _speed;
    
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _speed = speed;
    }


    public override double ReturnSpeed()
    {
        return _speed;
        // Console.WriteLine($"Cycling Speed Is: {(_speed):F3} kilometers per hour");
    }

    public override double ReturnPace()
    {
        return (_duration / (_speed * _duration)) * 60;
        // Console.WriteLine($"Cycling Pace is: {((_duration / (_speed * _duration)) * 60):F3} minutes per kilometer");
    }

    public override double ReturnDistance()
    {
        return _speed * _duration;
        // Console.WriteLine($"Cycling Distance is: {(_speed * _duration):F3} kilometers");
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_duration} min): Distance {ReturnSpeed():F3} km, Speed: {ReturnSpeed():F3} kph, Pace: {ReturnPace():F3} min per km";
    }
}