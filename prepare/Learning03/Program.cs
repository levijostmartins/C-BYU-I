using System;
using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string FString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double FDecimal()
    {
        return (double)_top / (double)_bottom;
    }

class Program
{
    static void Main(string[] args)
    {
        Fraction F1 = new Fraction();
        Console.WriteLine(F1.FString());
        Console.WriteLine(F1.FDecimal());
        Fraction F2 = new Fraction(5);
        Console.WriteLine(F2.FString());
        Console.WriteLine(F2.FDecimal());
        Fraction F3 = new Fraction(3, 4);
        Console.WriteLine(F3.FString());
        Console.WriteLine(F3.FDecimal());
        Fraction F4 = new Fraction(1, 3);
        Console.WriteLine(F4.FString());
        Console.WriteLine(F4.FDecimal());
        }
    }

}