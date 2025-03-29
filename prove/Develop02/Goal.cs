
public class Goal
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesc;
    protected int _goalPoints;

    public Goal(string _type, string _name, string _desc, int _points)
    {
        _goalType = _type;
        _goalName = _name;
        _goalDesc = _desc;
        _goalPoints = _points;
    }

    public void ConstuctorSetup()
    {
        Console.WriteLine("What type of Goal would you like to create? ");
        string _type = Console.ReadLine();
        Console.WriteLine("What is the name of your goal? ");
        string _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string _desc = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        string _pointsInput = Console.ReadLine();
        int _points = int.Parse(_pointsInput);
    }



    public void Display()
    {   Console.WriteLine("Goal: \n------------------");
        Console.WriteLine($"Type: {_goalType}");
        Console.WriteLine($"Name: {_goalName}");
        Console.WriteLine($"Description: {_goalDesc}");
        Console.WriteLine($"Points: {_goalPoints}");
    }
}