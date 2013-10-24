using System;
using System.Collections.Generic;

//From the book - create class Book and class Library
public class Library
{
    private string name;
    private List<Book> bookList;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public List<Book> BookList
    {
        get { return this.bookList; }
        set { this.bookList = value; }
    }

    public Library(string name, List<Book> bookList)
    {
        this.Name = name;
        this.BookList = bookList;
    }

    public List<Book> AddBook(Book book)
    {
        this.bookList.Add(book);
        return this.bookList;
    }

    public List<Book> RemoveBook(Book book)
    {
        foreach (var item in this.bookList)
        {
            if (item.Equals(book))
            {
                this.bookList.Remove(item);
                break;
            }
        }
        return this.bookList;
    }

    public void PrintBook(Book book)
    {
        string bookInfo = string.Format("Title {0}, Author {1}, Publisher {2}\r\nYear of Release {3:yyyy}, ISBN number {4}",
            book.Title, book.Author, book.Publisher, book.Year, book.ISBN);
        Console.WriteLine(bookInfo);
    }

    public List<Book> FindBook(string bookAuthor)
    {
        List<Book> collection = new List<Book>();
        for (int count = 0; count < this.BookList.Count; count++)
        {
            Book currentBook = this.BookList[count];
            if (currentBook.Author.Equals(bookAuthor))
            {
                collection.Add(currentBook);
            }
        }

        return collection;
    }
}