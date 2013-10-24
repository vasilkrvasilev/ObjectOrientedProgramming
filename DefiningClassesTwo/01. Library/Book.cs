using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

//From the book - create class Book and class Library
public class Book
{
    private string title;
    private string author;
    private string publisher;
    private DateTime year;
    private string iSBN;

    public string Title
    {
        get { return this.title; }
        set { this.title = value; }
    }

    public string Author
    {
        get { return this.author; }
        set { this.author = value; }
    }

    public string Publisher
    {
        get { return this.publisher; }
        set { this.publisher = value; }
    }

    public DateTime Year
    {
        get { return this.year; }
        set { this.year = value; }
    }

    public string ISBN
    {
        get { return this.iSBN; }
        set { this.iSBN = value; }
    }

    public Book(string title, string author, string publisher, DateTime year, string iSBN)
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = publisher;
        this.Year = year;
        this.ISBN = iSBN;
    }

    public static Book CreateBook()
    {
        Console.WriteLine("Enter title of the book");
        string bookTitle = Console.ReadLine();
        Console.WriteLine("Enter author of the book");
        string bookAuthor = Console.ReadLine();
        Console.WriteLine("Enter publisher of the book");
        string bookPublisher = Console.ReadLine();
        Console.WriteLine("Enter year of release of the book");
        DateTime bookYear = DateTime.ParseExact(Console.ReadLine(), "yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Enter ISBN of the book");
        string bookISBN = Console.ReadLine();
        Book book = new Book(bookTitle, bookAuthor, bookPublisher, bookYear, bookISBN);
        return book;
    }
}