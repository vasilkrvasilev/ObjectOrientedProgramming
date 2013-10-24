using System;

//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
//(height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that 
//at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program 
//that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.

//Use classes Shape, Circle, Triangle and Rectangle
public class CreateShape
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        Shape[] array = new Shape[3 * number];
        try
        {
            for (int count = 0; count < array.Length; count += 3)
            {
                Triangle currentTriangle = Triangle.CreateTriangle();
                array[count] = currentTriangle;
                Rectangle currentRectangle = Rectangle.CreateRectangle();
                array[count + 1] = currentRectangle;
                Circle currentCircle = Circle.CreateCircle();
                array[count + 2] = currentCircle;
            }

            for (int count = 0; count < array.Length; count++)
            {
                Shape currentShape = array[count];
                double currentArea = currentShape.CalculateSurface();
                Console.WriteLine("This shape is {0} with height {1:F2} and width {2:F2} with surface equals to {3:F2}",
                    currentShape.GetType(), currentShape.Height, currentShape.Width, currentArea);
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

    }
}