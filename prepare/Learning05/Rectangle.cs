
using System.Drawing;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string colorInput, double lengthInput, double widthInput): base(colorInput)
    {
        _length = lengthInput;
        _width = widthInput;
    }

    public override double GetArea()
    {
        return _length * _width; 
    }
}