
public class Shape{

    protected string _color;

    public Shape(string colorInput)
    {
        _color = colorInput;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string input)
    {
        _color = input;
    }

    public virtual double GetArea()
    {
        return 0;
    }

}