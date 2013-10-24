using System;

//Add extention mathod to class Point3D
public static class Distance
{
    public static double CalculateDiscance(Point3D firstPoint, Point3D secondPoint)
    {
        double abscissaDistance = Math.Abs(firstPoint.Abscissa - secondPoint.Abscissa);
        double ordinateDistance = Math.Abs(firstPoint.Ordinate - secondPoint.Ordinate);
        double dimensionDistance = Math.Abs(firstPoint.Dimension - secondPoint.Dimension);
        double squareSum = (abscissaDistance * abscissaDistance) + (ordinateDistance * ordinateDistance) +
            (dimensionDistance * dimensionDistance);
        double distance = Math.Sqrt(squareSum);
        return distance;
    }
}