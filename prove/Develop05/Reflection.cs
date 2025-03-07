
class Reflection : Activity
{
    private List<string> _prompts = new List<string>()
{
    "-- Think of a time when you stood up for someone else. --",
    "-- Think of a time when you did something really difficult. --",
    "-- Think of a time when you helped someone in need. --",
    "-- Think of a time when you did something truly selfless. --"
};

    private List<string> _questions = new List<string>()
{
    "> Why was this experience meaningful to you?",
    "> Have you ever done anything like this before?",
    "> How did you get started?",
    "> How did you feel when it was complete?",
    "> What made this time different than other times when you were not as successful?",
    "> What is your favorite thing about this experience?",
    "> What could you learn from this experience that applies to other situations?",
    "> What did you learn about yourself through this experience?",
    "> How can you keep this experience in mind in the future?"
};

    private HashSet<int> selectedIndexes = new HashSet<int>();
    private Random _random = new Random();
    private int _listedItems = 0;

    public void ReflectionIntro()
    {
        Intro("Reflection Activity. ", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ");
        _activityType = "Reflection";
    }

    public void RepeatEnter2(string _string)
    {
        for (int i = 0; i < 1; i++)
        _listedItems = _listedItems + 1;
    }

    public void ReflectIn()
    {
        Console.Clear();
        GetReady(5);

        DateTime _startTime = DateTime.Now;
        DateTime _futureTime = _startTime.AddSeconds(_sessionDuration);
        int _index = _random.Next(_prompts.Count);
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(_prompts[_index]);
        Console.WriteLine("\nWhen you have something in mind, press 'Enter' to continue: ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();

        while (DateTime.Now < _futureTime)
        {
            if (selectedIndexes.Count == _questions.Count)
            {
                break;
            }
            int _index2;
            do 
            {
                _index2 = _random.Next(_questions.Count); 
            }
            while (selectedIndexes.Contains(_index2));
            Console.WriteLine(_questions[_index2]);
            selectedIndexes.Add(_index2);
            Pause(10);
            
        }

        Console.WriteLine("\nWell done!");
        Pause(2);
        DisplayDuration(_sessionDuration, _activityType);
        Pause(5);
        Console.Clear();
    }
}