
using System;

class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int numerator)
    {
        _topNum = numerator;
        _bottomNum = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _topNum = numerator;
        _bottomNum = denominator;
    }

    public void Display()
    {
        Console.WriteLine($"{_topNum}/{_bottomNum}");
    }

    public int GetTopNumber()
    {
        return _topNum;
    }

    private void SetTopNumber(int numerator)
    {
        _topNum = numerator;
    }

    public int GetBottomNumber()
    {
        return _bottomNum;
    }

    private void SetBottomNumber(int denominator)
    {
        _bottomNum = denominator;
    }

    public string GetFractionString() // Ignore this version of GetFractionString, the 2nd version works as intended
    {
        SetTopNumber(3);
        SetBottomNumber(4);
        return _topNum + "/" + _bottomNum;
    }

        public string GetFractionString2()
    {
        return _topNum + "/" + _bottomNum;
    }

    public double GetDecimalValue() // Ignore this version of GetDecimalValue, the 2nd version works as intended
    {
        SetTopNumber(3);
        SetBottomNumber(4);
        return (double)_topNum/_bottomNum;        
    }

    public double GetDecimalValue2()
    {
        return (double)_topNum/_bottomNum;        
    }

}