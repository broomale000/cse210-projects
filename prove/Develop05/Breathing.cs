
class Breathing : Activity
{
    
    public void BreathingIntro()
    {
        Intro("Breathing Activity. ", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. ");
    }

    public void BreatheInOut()
    {
        Console.Clear();
        DateTime _startTime = DateTime.Now;
        DateTime _futureTime = _startTime.AddSeconds(_sessionDuration);

        if (DateTime.Now < _futureTime)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);
            Console.WriteLine("Now breathe out...");
            Countdown(6);
        }
    }
}