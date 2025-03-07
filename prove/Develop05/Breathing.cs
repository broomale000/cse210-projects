
class Breathing : Activity
{
    
    public void BreathingIntro()
    {
        Intro("Breathing Activity.", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ");
        _activityType = "Breathing";
    }

    public void BreatheInOut()
    {
        Console.Clear();
        DateTime _startTime = DateTime.Now;
        DateTime _futureTime = _startTime.AddSeconds(_sessionDuration);

        while (DateTime.Now < _futureTime)
        {
            GetReady(5);
            Console.WriteLine("\nBreathe in...");
            Countdown(4);
            Console.WriteLine("Now breathe out...");
            Countdown(6);
        }
        Console.WriteLine("Well done!");
        Pause(2);
        DisplayDuration(_sessionDuration, _activityType);
        Pause(5);
        Console.Clear();
    }
}