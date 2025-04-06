class Activity{

    protected string _date;
    protected int _duration; // Minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double ReturnSpeed() 
    {
        return 0;
    }   

    public virtual double ReturnPace()
    {
        return 0;
    }

    public virtual double ReturnDistance()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return "0";
    }
}