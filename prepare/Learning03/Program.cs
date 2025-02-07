using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction();
        Fraction number1 = new Fraction();
        Fraction number2 = new Fraction(6);
        Fraction number3 = new Fraction(6, 7);
        Fraction number4 = new Fraction(5);
        Fraction number5 = new Fraction(3, 4);
        Fraction number6 = new Fraction(1, 3);

        number.Display();
        number1.Display();
        number2.Display();
        number3.Display();
        Console.WriteLine(number.GetFractionString());
        Console.WriteLine(number.GetDecimalValue());

        Console.WriteLine("\nBelow are the intended display values: ");

        number1.Display();
        Console.WriteLine(number1.GetDecimalValue2());
        number4.Display();
        Console.WriteLine(number4.GetDecimalValue2());
        number5.Display();
        Console.WriteLine(number5.GetDecimalValue2());
        number6.Display();
        Console.WriteLine(number6.GetDecimalValue2());
    }
}