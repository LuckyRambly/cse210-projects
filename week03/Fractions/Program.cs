using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Constructors Test ---");

        // Constructor #1
        Fraction f1 = new Fraction();
        Console.WriteLine($"f1 (1/1): {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");

        // Constructor #2
        Fraction f2 = new Fraction(5);
        Console.WriteLine($"f2 (5/1): {f2.GetFractionString()}");
        Console.WriteLine($"Decimal: {f2.GetDecimalValue()}");

        // Constructor #3
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"f3 (3/4): {f3.GetFractionString()}");
        Console.WriteLine($"Decimal: {f3.GetDecimalValue()}");

        Console.WriteLine("\n--- Getters and setters time ---");

        f1.SetTop(6);
        f1.SetBottom(7);
        
        Console.WriteLine($"(GetTop): {f1.GetTop()}"); 
        Console.WriteLine($"(GetBottom): {f1.GetBottom()}"); 
        Console.WriteLine($"string: {f1.GetFractionString()}"); 

        Console.WriteLine("Verification:");
        f1.SetBottom(0); // we are going 1 people.
        Console.WriteLine($"f1 (after SetBottom(0)): {f1.GetFractionString()}"); 

        Console.WriteLine("\n--- Returns ---");

        // 1/1
        DisplayFraction(new Fraction());

        // 5/1
        DisplayFraction(new Fraction(5));

        // 3/4
        DisplayFraction(new Fraction(3, 4));

        // 1/3
        DisplayFraction(new Fraction(1, 3));
    }

    static void DisplayFraction(Fraction f)
    {
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
    }
}