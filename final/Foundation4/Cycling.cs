class Cycling : Activity
{

    private double _speed;
    
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _date = date;
        _duration = duration;
        _speed = speed;
    }


    public override void CalculateSpeed()
    {
        Console.WriteLine($"Cycling Speed Is: {(_speed):F3} kilometers per hour");
    }

    public override void CalculatePace()
    {
        Console.WriteLine($"Cycling Pace is: {((_duration / (_speed * _duration)) * 60):F3} minutes per kilometer");
    }

    public override void Distance()
    {
        Console.WriteLine($"Cycling Distance is: {(_speed * _duration):F3} kilometers");
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} Cycling ({_duration} min): Distance {(_speed * _duration):F3} km, Speed: {(_speed):F3} kph, Pace: {((_duration / (_speed * _duration)) * 60):F3} min per km");
    }
}