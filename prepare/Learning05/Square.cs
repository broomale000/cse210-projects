
using System.Drawing;

public class Square : Shape
{
    private double _side;

    public Square(string colorInput, double sideInput): base(colorInput)
    {
        _side = sideInput;
    }

    public override double GetArea()
    {
        return _side * _side; 
    }
}