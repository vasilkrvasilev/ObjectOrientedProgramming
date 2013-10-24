using System;

//Set initial fields, properties and methods according to task one and two
public struct Point3D
{
    //private static Point3D pointO;
    private int abscissa;
    private int ordinate;
    private int dimension;

    public int Abscissa
    {
        get { return abscissa; }
        set { abscissa = value; }
    }

    public int Ordinate
    {
        get { return ordinate; }
        set { ordinate = value; }
    }

    public int Dimension
    {
        get { return dimension; }
        set { dimension = value; }
    }

    public static readonly Point3D PointO = new Point3D(0, 0, 0);

    public Point3D(int abscissa, int ordinate, int dimension)
        : this()
    {
        this.Abscissa = abscissa;
        this.Ordinate = ordinate;
        this.Dimension = dimension;
    }

    public override string ToString()
    {
        string printedPoint = string.Format("The point has coordinates [{0}, {1}, {2}]", this.Abscissa, this.Ordinate, this.Dimension);
        return printedPoint;
    }
}