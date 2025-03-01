using System;

public class Book
{
    string title;
    string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Book: \"{title}\" by {author}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book("The Little Prince", "Antoine de Saint-Exupéry");
        myBook.DisplayDetails();
    }
}