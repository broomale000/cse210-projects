

class Eternal : Goal
{

    public Eternal(string _type, string _name, string _desc, int _points) :base("Eternal", "Eternal Goal", "Description", 50)
    {
    }

    public void DisplayStuff()
    {
        Console.WriteLine($"Type: {_goalType}");
    }

}