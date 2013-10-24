using System;
using System.Text;

//Class GenericList inherits class GenericArray, add method Grow(), and override methods Add() and Insert()
public class GenericList<T> : GenericArray<T>
{
    public GenericList(int length) : base(length)
    {
    }

    public T[] Grow()
    {
        T[] grownArray = new T[this.Length];
        for (int position = 0; position < this.elements.Length; position++)
        {
            grownArray[position] = this.elements[position];
        }
        return grownArray;
    }

    public override void Add(T element)
    {
        if (this.Count == this.Length)
        {
            this.Length *= 2;
            T[] grownArray = Grow();
            this.elements = new T[this.Length];
            this.elements = grownArray;
        }
        this.elements[this.Count] = element;
        this.Count++;
    }

    public override void Insert(int index, T element)
    {
        if (index >= this.Length || index < 0)
        {
            throw new ArgumentException(
                    string.Format("Invalid input! You should enter number between 0 and {0}", this.Length - 1));
        }

        if (this.Count == this.Length)
        {
            this.Length *= 2;
            T[] grownArray = Grow();
            this.elements = new T[this.Length];
            this.elements = grownArray;
        }

        if (index <= this.Count)
        {
            for (int position = this.Count - 1; position >= index; position--)
            {
                this.elements[position + 1] = this.elements[position];
            }
            this.elements[index] = element;
            this.Count++;
        }
        else
        {
            Console.WriteLine(
                "This position is surrounded by empty elements! You should enter number between 0 and {0}", this.Count);
        }
    }
}