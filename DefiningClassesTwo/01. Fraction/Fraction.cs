using System;

//From the book - create class Fraction
public class Fraction
{
    private int numerator;
    private int denumerator;
    private decimal fractionValue;

    public int Numerator
    {
        get { return this.numerator; }
        set { this.numerator = value; }
    }

    public int Denumerator
    {
        get { return this.denumerator; }
        set { this.denumerator = value; }
    }

    public decimal FractionValue
    {
        get { return this.fractionValue; }
        set { this.fractionValue = value; }
    }

    public Fraction()
    {
    }

    public Fraction(int numerator, int denumerator)
    {
        this.Numerator = numerator;
        this.Denumerator = denumerator;
    }

    public void CalculateFractionValue()
    {
        if (this.denumerator != 0)
        {
            this.fractionValue = (decimal)this.numerator / this.denumerator;
        }
        else
        {
            this.fractionValue = 0;
        }
    }

    public Fraction Parce(string input)
    {
        string[] fractionData = input.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        this.numerator = int.Parse(fractionData[0]);
        this.denumerator = int.Parse(fractionData[1]);
        Fraction fraction = new Fraction(numerator, denumerator);
        return fraction;
    }

    public override string ToString()
    {
        string fractionToString = string.Format("{0}/{1}", this.numerator, this.denumerator);
        return fractionToString;
    }

    public static int EuclidianAlgorithm(int firstNumber, int secondNumber)
    {
        int greaterNumber;
        int smallerNumber;
        if (firstNumber >= secondNumber)
        {
            greaterNumber = firstNumber;
            smallerNumber = secondNumber;
        }
        else
        {
            greaterNumber = secondNumber;
            smallerNumber = firstNumber;
        }
        int remainder;
        do
        {
            remainder = greaterNumber % smallerNumber;
            greaterNumber = smallerNumber;
            smallerNumber = remainder;
        }
        while (remainder != 0);
        return greaterNumber;
    }

    public void Cut()
    {
        if (this.Denumerator != 0)
        {
            int cutNumber = EuclidianAlgorithm(this.Numerator, this.Denumerator);
            this.Numerator /= cutNumber;
            this.Denumerator /= cutNumber;
            if (cutNumber == 1)
            {
                Console.WriteLine("The fraction cannot be cut");
            }
            Console.WriteLine("Cut fraction {0}", this.ToString());
        }
        else
        {
            Console.WriteLine("The fraction cannot be cut");
        }
    }
}
