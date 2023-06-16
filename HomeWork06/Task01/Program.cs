using System.Reflection;
using System.Runtime.InteropServices;

using LibrarySystem;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        




        Library library = new Library();
        Book book1 = new Book();
        book1.Title = "The lord of the rings";
        book1.Author = "J. R. R. Tolkin";

        Book book2 = new Book();
        book2.Title = "The Little Prince";
        book2.Author = "Antoine de Saint-Exupéry";

        Book[] books = { book1, book2 };
        library.setBooks(books);

        Book book3 = new Book();
        book3.Title = "Harry Potter and the Philosopher's Stone";
        book3.Author = "J. K. Rowling";

        library[1] = book3;

        Book book4 = new Book();
        book4.Title = "The Hunger Games";
        book4.Author = "Suzanne Collins";

        library.AddBook(book4);

        Console.WriteLine(library[library.Count-1].Title);
        Console.WriteLine(library.Count);


        library.RemoveBook(1);

        if (library[1] == null)
        {
            Console.WriteLine("Book has been removed");
        }
        Console.WriteLine(library.Count);



        Book[] selectedBooks = new Book [( library.FindBooks(title: "The Hunger Games")).Length ];

        
        Console.WriteLine(selectedBooks.Length);

        Console.ReadLine();

    }
}