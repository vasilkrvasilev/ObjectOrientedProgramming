using System;
using System.Collections.Generic;

//Use classes Book and class Library
public class CreateLibrary
{
    static void Main()
    {
        Console.WriteLine("Enter name of the library");
        string name = Console.ReadLine();
        List<Book> bookList = new List<Book>();
        Library library = new Library(name, bookList);
        Console.WriteLine("Enter number of books");
        int number = int.Parse(Console.ReadLine());
        for (int count = 0; count < number; count++)
        {
            Book book = Book.CreateBook();
            library.AddBook(book);
            Console.WriteLine();
        }

        for (int count = 0; count < bookList.Count; count++)
        {
            Book book = library.BookList[count];
            library.PrintBook(book);
            Console.WriteLine();
        }

        List<Book> stevenKing = library.FindBook("Steven King");
        Console.WriteLine("Steven King Books");
        for (int count = 0; count < stevenKing.Count; count++)
        {
            Book currentBook = stevenKing[count];
            library.PrintBook(currentBook);
            library.RemoveBook(currentBook);
        }

        Console.WriteLine();
        Console.WriteLine("Library after removing books");
        for (int count = 0; count < library.BookList.Count; count++)
        {
            Book book = library.BookList[count];
            library.PrintBook(book);
            Console.WriteLine();
        }
    }
}