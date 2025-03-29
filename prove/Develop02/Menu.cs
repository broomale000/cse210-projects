using System.Runtime.CompilerServices;

class Menu
{
    int _displayPoints = 0;
    public void Display()
    {
        Console.WriteLine($"You have {_displayPoints} points. ");
        Console.WriteLine("\n1. Create New Goals\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n");
        Console.Write("Select a choice from the menu: ");
    }

    public void DisplayBranch()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
    }

    public void UpdateDispalyPoints(int _inputPoints)
    {
        _displayPoints = _inputPoints;
    }
}