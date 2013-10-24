using System;

//Class IndexMatrix inherits class Matrix, add indexer
public class IndexMatrix<T> : Matrix<T> where T : struct, IFormattable
{
    public IndexMatrix(int hight, int width) : base(hight, width)
    {
    }

    public T this[int row, int column]
    {
        get
        {
            if ((row < 0 || row >= this.Hight) && (column < 0 || column >= this.Width))
            {
                throw new ArgumentException("Invalid input! Index out of range");
            }

            return this.multyArray[row, column];
        }
        set
        {
            if ((row < 0 || row >= this.Hight) && (column < 0 || column >= this.Width))
            {
                throw new ArgumentException("Invalid input! Index out of range");
            }
            this.multyArray[row, column] = value;
        }
    }
}