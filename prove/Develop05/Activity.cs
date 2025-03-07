class Activity
{
    protected int _sessionDuration = 0;
    protected string _activityType = "";
    public void GetReady(int _pauseTimer)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");

        for (int i = 1; i <= _pauseTimer; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

        public void Pause(int _pauseTimer)
    {

        for (int i = 1; i <= _pauseTimer; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void Countdown(int _countTimer)
    {
        for (int i = _countTimer; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Intro(string _activityType, string _activityGoal)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityType} ");
        Console.WriteLine("");
        Console.WriteLine($"This activity will help you {_activityGoal} ");
        Console.WriteLine();
    }

    public void SetSessionDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int _sessionTimer = int.Parse(Console.ReadLine());
        _sessionDuration = _sessionTimer;
    }

    public void DisplayDuration(int _sessionDuration, string _activityType)
    {
        Console.WriteLine($"\nYou have completed {_sessionDuration} seconds of the {_activityType} activity! ");
    }
}