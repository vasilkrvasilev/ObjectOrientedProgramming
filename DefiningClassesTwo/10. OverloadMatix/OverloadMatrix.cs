using System;

//Class OverloadMatrix inherits class IndexMatrix, add overload operators +, -, *, true and false
class OverloadMatrix<T> : IndexMatrix<T> where T : struct, IFormattable
{
    public OverloadMatrix(int hight, int width) : base(width, hight)
    {
    }

    public static OverloadMatrix<T> operator +(OverloadMatrix<T> first, OverloadMatrix<T> second)
    {
        if (first.Hight != second.Hight || first.Width != second.Width)
        {
            throw new ArgumentException("You can sum only matrices with same hight and width");
        }
        else
        {
            dynamic sum = new OverloadMatrix<T>(first.Hight, first.Width);
            for (int currentRow = 0; currentRow < first.Hight; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < first.Width; currentColumn++)
                {
                    sum[currentRow, currentColumn] = int.Parse(first[currentRow, currentColumn].ToString()) +
                        int.Parse(second[currentRow, currentColumn].ToString());
                }
            }
            return sum;
        }
    }

    public static OverloadMatrix<T> operator -(OverloadMatrix<T> first, OverloadMatrix<T> second)
    {
        if (first.Hight != second.Hight || first.Width != second.Width)
        {
            throw new ArgumentException("You can subtract only matrices with same hight and width");
        }
        else
        {
            dynamic subtract = new OverloadMatrix<T>(first.Hight, first.Width);
            for (int currentRow = 0; currentRow < first.Hight; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < first.Width; currentColumn++)
                {
                    subtract[currentRow, currentColumn] = int.Parse(first[currentRow, currentColumn].ToString()) -
                        int.Parse(second[currentRow, currentColumn].ToString());
                }
            }
            return subtract;
        }
    }

    public static OverloadMatrix<T> operator *(OverloadMatrix<T> first, OverloadMatrix<T> second)
    {
        if (first.Width != second.Hight)
        {
            throw new ArgumentException(
                "You can multyply only matrices, when the width of the first is equal to the hight of the second");
        }
        else
        {
            dynamic multiply = new OverloadMatrix<T>(first.Hight, second.Width);
            for (int currentRow = 0; currentRow < first.Hight; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < second.Width; currentColumn++)
                {
                    for (int currentCouple = 0; currentCouple < first.Width; currentCouple++)
                    {
                        multiply[currentRow, currentColumn] += 
                            (int.Parse(first[currentRow, currentCouple].ToString()) *
                            int.Parse(second[currentCouple, currentColumn].ToString()));
                    }
                }
            }
            return multiply;
        }
    }

    public static bool operator true(OverloadMatrix<T> first)
    {
        bool nonZero = false;
        for (int currentRow = 0; currentRow < first.Hight; currentRow++)
        {
            for (int currentColumn = 0; currentColumn < first.Width; currentColumn++)
            {
                if (!first[currentRow, currentColumn].Equals(0))
                {
                    nonZero = true;
                    break;
                }
            }
        }
        if (nonZero)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator false(OverloadMatrix<T> first)
    {
        bool nonZero = false;
        for (int currentRow = 0; currentRow < first.Hight; currentRow++)
        {
            for (int currentColumn = 0; currentColumn < first.Width; currentColumn++)
            {
                if (!first[currentRow, currentColumn].Equals(0))
                {
                    nonZero = true;
                    break;
                }
            }
        }
        if (nonZero)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}