using System;
using System.Threading.Tasks;

//Create InvalidRangeException class with properties Start and End and overriden Message
 public class InvalidRangeException<T> : ApplicationException where T : IComparable
{
     private T start;
     private T end;

     public T Start
     {
         get { return this.start; }
     }

     public T End
     {
         get { return this.end; }
     }

     public InvalidRangeException(T start, T end)
         : base()
     {
         this.start = start;
         this.end = end;
     }

     public override string Message
     {
         get
         {
             string result = string.Format(
                 "Invalid input! The entered value is out of range! You should enter value in the range of {0:dd.MM.yyyy} and {1:dd.MM.yyyy}.",
                 this.start, this.end);
             return result;
         }
     }
}