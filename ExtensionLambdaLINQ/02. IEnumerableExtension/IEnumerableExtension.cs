using System;
using System.Collections.Generic;

//Extention methods Sum(), FindAverage(), Multiply(), FindMin() and FindMax() to IEnumerable
public static class IEnumerableExtension
{
    public static T Sum<T>(this IEnumerable<T> array) where T : IComparable
    {
        dynamic sum = 0;
        foreach (dynamic element in array)
        {
            sum = sum + (int)element;
        }
        return sum;
    }

    public static double FindAverage<T>(this IEnumerable<T> array) where T : IComparable
    {
        double sum = 0;
        int count = 0;
        foreach (dynamic element in array)
        {
            sum += (int)element;
            count++;
        }
        double average = sum / count;
        return average;
    }

    public static T Multiply<T>(this IEnumerable<T> array) where T : IComparable
    {
        dynamic product = 1;
        foreach (dynamic element in array)
        {
            product = product * (int)element;
        }
        return product;
    }

    public static T FindMin<T>(this IEnumerable<T> array) where T : IComparable
    {
        dynamic min = int.MaxValue;
        foreach (var element in array)
        {
            if (element.CompareTo(min) < 0)
            {
                min = element;
            }
        }
        return min;
    }

    public static T FindMax<T>(this IEnumerable<T> array) where T : IComparable
    {
        dynamic max = int.MinValue;
        foreach (var element in array)
        {
            if (element.CompareTo(max) > 0)
            {
                max = element;
            }
        }
        return max;
    }
}