using System;

//Set fields, properties and methods of class Path according to task four
public class Path
{
    private int length;
    private Point3D[] elements;

    public int Length
    {
        get { return this.length; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input! You should enter non-negative integer number");
            }
            this.length = value;
        }
    }

    public Path(int length)
    {
        this.Length = length;
        this.elements = new Point3D[length];
    }

    public Point3D this[int index]
    {
        get
        {
            if (index < 0 || index >= this.length)
            {
                throw new ArgumentException(
                    string.Format("Invalid input! You should enter number between 0 and {0}", this.length - 1));
            }
            return this.elements[index];
        }
        set
        {
            if (index < 0 || index >= this.length)
            {
                throw new ArgumentException(
                    string.Format("Invalid input! You should enter number between 0 and {0}", this.length - 1));
            }
            this.elements[index] = value;
        }
    }
}