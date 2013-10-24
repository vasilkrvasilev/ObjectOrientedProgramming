using System;
using System.Text;

//Set initial fields, properties and methods of class GenericArray according to task five
//Methods Add() and Insert() are virtual
public class GenericArray<T>
{
    private int length;
    protected T[] elements;
    private int count = 0;

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

    public int Count
    {
        get { return this.count; }
        set { this.count = value; }
    }

    public GenericArray(int length)
    {
        this.Length = length;
        this.elements = new T[this.length];
    }

    public virtual void Add(T element)
    {
        if (this.count >= this.length)
        {
            throw new ArgumentException(
                "Capacity is exceeded !You cannot add more elements in this GenericArray");
        }
        this.elements[this.count] = element;
        this.count++;
    }

    public T this[int index]
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

    public void Remove(int index)
    {
        if (index >= this.length || index < 0)
        {
            throw new ArgumentException(
                    string.Format("Invalid input! You should enter number between 0 and {0}", this.length - 1));
        }

        if (this.count == 0)
        {
            throw new ArgumentException(
                "GenericArray is empty! You cannot remove any element in this GenericArray");
        }

        if (index < this.count)
        {
            for (int position = index; position < this.count - 1; position++)
            {
                this.elements[position] = this.elements[position + 1];
            }
            this.elements[this.count - 1] = default(T);
            this.count--;
        }
        else
        {
            Console.WriteLine("This element is empty");
        }
    }

    public virtual void Insert(int index, T element)
    {
        if (this.count >= this.length)
        {
            throw new ArgumentException(
                "Capacity is exceeded! You cannot insert more elements in this GenericArray");
        }

        if (index >= this.length || index < 0)
        {
            throw new ArgumentException(
                    string.Format("Invalid input! You should enter number between 0 and {0}", this.length - 1));
        }

        if (index <= this.count)
        {
            for (int position = this.count - 1; position >= index; position--)
            {
                this.elements[position + 1] = this.elements[position];
            }
            this.elements[index] = element;
            this.count++;
        }
        else
        {
            Console.WriteLine(
                "This position is surrounded by empty elements! You should enter number between 0 and {0}", this.count);
        }
    }

    public void Clear()
    {
        for (int position = 0; position < count; position++)
        {
            this.elements[position] = default(T);
        }
        this.count = 0;
    }

    public int Find(T elementValue)
    {
        int elementIndex = -1;
        for (int position = 0; position < count; position++)
        {
            if (this.elements[position].Equals(elementValue))
            {
                elementIndex = position;
                break;
            }
        }
        if (elementIndex == -1)
        {
            Console.WriteLine("This GenericArray does not consist element with such value");
        }
        return elementIndex;
    }

    public override string ToString()
    {
        StringBuilder printGenericArray = new StringBuilder();
        for (int position = 0; position < count; position++)
        {
            printGenericArray.Append(this.elements[position].ToString());
            printGenericArray.Append("\r\n");
        }
        return printGenericArray.ToString();
    }
}