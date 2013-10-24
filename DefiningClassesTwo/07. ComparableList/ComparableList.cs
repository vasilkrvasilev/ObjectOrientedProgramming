using System;
using System.Collections.Generic;
using System.Text;

//Class GenericList inherits class GenericList, add methods Min() and Max()
public class ComparableList<T> : GenericList<T>
{
    public ComparableList(int length) : base(length)
    {
    }

    public T Min<T>(T first, T second) where T : IComparable<T>
    {
        int firstNumber;
        int secondNumber;
        bool firstIsNumber = int.TryParse(first.ToString(), out firstNumber);
        bool secondIsNumber = int.TryParse(second.ToString(), out secondNumber);
        if (firstIsNumber && secondIsNumber)
        {
            if (firstNumber <= secondNumber)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        else
        {
            if (first.ToString().CompareTo(second.ToString()) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }

    public T Max<T>(T first, T second) where T : IComparable<T>
    {
        int firstNumber;
        int secondNumber;
        bool firstIsNumber = int.TryParse(first.ToString(), out firstNumber);
        bool secondIsNumber = int.TryParse(second.ToString(), out secondNumber);
        if (firstIsNumber && secondIsNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        else
        {
            if (first.ToString().CompareTo(second.ToString()) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}