using System;

//Set initial fields, properties and methods of class Matrix according to task eight
public class Matrix<T> where T: struct, IFormattable
{
    private int hight;
    private int width;
    protected T[,] multyArray;
    private int count = 0;

    public int Hight
    {
        get { return this.hight; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! You should enter positive number");
            }
            this.hight = value;
        }
    }

    public int Width
    {
        get { return this.width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! You should enter positive number");
            }
            this.width = value;
        }
    }

    public int Count
    {
        get { return this.count; }
    }

    public Matrix(int hight, int width)
    {
        this.Hight = hight;
        this.Width = width;
        multyArray = new T[this.hight, this.width];
    }
}