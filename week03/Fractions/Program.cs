using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");


        Fraction f1 = new Fraction();
        Console.WriteLine (f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

    }


}