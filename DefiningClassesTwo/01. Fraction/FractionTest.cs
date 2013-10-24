using System;

//Use class Fraction
public class FractionTest
{
    static void Main()
    {
        Console.WriteLine("Enter fraction");
        string input = Console.ReadLine();
        Fraction fraction = new Fraction();
        fraction = fraction.Parce(input);
        fraction.CalculateFractionValue();
        Console.WriteLine("Decimal value of the fraction is:");
        Console.WriteLine(fraction.FractionValue);
        fraction.Cut();
        Console.WriteLine("Fraction after cut is:");
        Console.WriteLine(fraction.ToString());
        Console.WriteLine("Decimal value of the cut fraction is:");
        Console.WriteLine(fraction.FractionValue);

        Console.WriteLine("Enter numerator");
        int numerator = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter denumerator");
        int denumerator = int.Parse(Console.ReadLine());
        Fraction otherFraction = new Fraction(numerator, denumerator);
        Console.WriteLine("Fraction is:");
        Console.WriteLine(otherFraction.ToString());
        otherFraction.CalculateFractionValue();
        Console.WriteLine("Decimal value of the fraction is:");
        Console.WriteLine(otherFraction.FractionValue);
        otherFraction.Cut();
        Console.WriteLine("Fraction after cut is:");
        Console.WriteLine(otherFraction.ToString());
        Console.WriteLine("Decimal value of the cut fraction is:");
        Console.WriteLine(otherFraction.FractionValue);
    }
}