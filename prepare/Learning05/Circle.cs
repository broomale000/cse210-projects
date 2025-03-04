
using System.Drawing;
using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius;

    public Circle(string colorInput, double radiusInput): base(colorInput)
    {
        _radius = radiusInput;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}