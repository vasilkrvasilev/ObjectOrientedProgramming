using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//Define a class BitArray64 to hold 64 bit values inside an ulong value. 
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

//Create class BitArray64
class BitArray64 : IEnumerable<int>
{
    private List<ulong> elements;
    private int length;

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

    //Constructor is optianal, because it has an default value for length
    public BitArray64(int length = 4)
    {
        this.Length = length;
        this.elements = new List<ulong>(length);
    }

    //Implement indexer
    public ulong this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Length)
            {
                throw new ArgumentException(
                    string.Format("Invalid input! You should enter number between 0 and {0}", this.Length - 1));
            }

            return this.elements[index];
        }
        set
        {
            if (index < 0 || index >= this.Length)
            {
                throw new ArgumentException(
                    string.Format("Invalid input! You should enter number between 0 and {0}", this.Length - 1));
            }

            this.elements[index] = value;
        }
    }

    //Method to add elements - used to test the other methods of class BitArray64 in BitArray64Test
    public void AddElement(uint element)
    {
        this.elements.Add(element);
    }

    //Override Equals() method
    public static bool Equals(BitArray64 first, BitArray64 second)
    {
        bool isEqual = true;
        for (int count = 0; count < Math.Min(first.Length, second.Length); count++)
        {
            if (first[count] != second[count])
            {
                isEqual = false;
                break;
            }
        }

        if (isEqual && first.Length != second.Length)
        {
            isEqual = false;
        }

        return isEqual;
    }

    public static bool operator ==(BitArray64 first, BitArray64 second)
    {
        return Equals(first, second);
    }

    public static bool operator !=(BitArray64 first, BitArray64 second)
    {
        return !Equals(first, second);
    }

    public override bool Equals(object obj)
    {
        return Equals(this, obj as BitArray64);
    }

    //Override GetHeshCode() method
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    //Implement IEnumerable<int> interface
    public IEnumerator GetEnumerator()
    {
        return (this.elements as IEnumerable).GetEnumerator();
    }

    IEnumerator<int> IEnumerable<int>.GetEnumerator()
    {
        return (this.elements as IEnumerable<int>).GetEnumerator();
    }

    //Override ToString() method
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        foreach (ulong product in this.elements)
        {
            result.AppendLine(product.ToString());
        }

        return result.ToString();
    }
}