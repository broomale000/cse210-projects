class Activity{

    protected string _date;
    protected int _duration; // Minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual void CalculateSpeed() 
    {
        Console.WriteLine("-");
    }   

    public virtual void CalculatePace()
    {
        Console.WriteLine("-");
    }

    public virtual void Distance()
    {
        Console.WriteLine("-");
    }

    public virtual void GetSummary()
    {
        Console.WriteLine("-");
    }
}