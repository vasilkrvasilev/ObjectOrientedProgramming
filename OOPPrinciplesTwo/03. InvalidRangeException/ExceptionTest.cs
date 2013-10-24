using System;
using System.Globalization;
using System.Threading.Tasks;

//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end]. Write a sample application that demonstrates 
//the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
//and dates in the range [1.1.1980 … 31.12.2013].

//Use class InvalidRangeException
//Check for exceptions by if statements and throw if it occurred
//then catch it by try-catch block
public class ExceptionTest
{
    static void Main()
    {
        string stop = "1";
        int startNumber = 1;
        int endNumber = 100;
        DateTime startDate = new DateTime(1980, 1, 1);
        DateTime endDate = new DateTime(2013, 12, 31);
        while (stop != "0")
        {
            try
            {
                Console.WriteLine("Enter number");
                int number = int.Parse(Console.ReadLine());
                if (number < startNumber || number > endNumber)
                {
                    throw new InvalidRangeException<int>(startNumber, endNumber);
                }

                Console.WriteLine("Enter date in the format dd.MM.yyyy");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                if (date < startDate || date > endDate)
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate);
                }
            }
            catch (InvalidRangeException<int> irei)
            {
                Console.WriteLine(irei.Message);
            }
            catch (InvalidRangeException<DateTime> iredt)
            {
                Console.WriteLine(iredt.Message);
            }
            Console.WriteLine("Enter 0 to stop");
            stop = Console.ReadLine();
        }
    }
}