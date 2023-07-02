// See https://aka.ms/new-console-template for more information
using HomeWork13;
using System.Reflection;


Library library = new Library();
Library._capacity = 2;



try
{
    Book book1 = new Book("010010", "Harry Potter", "JK Rowling");
    Book book2 = new Book("010012", "Harry Potter 2", "JK Rowling");
   // Book book3 = new Book("010013", "Book3", "");
    Book book4 = new Book("010012", "Harry Potter 2", "JK Rowling");
    book4 = null;
    library.AddBook(book1);
    library.AddBook(book2);
    //library.AddBook(book1);
    library.AddBook(book4);

    library.GetBookList().ForEach(book => Console.WriteLine(book.GetTitle()));

    var findBook1 = library.GetBook("010010");
    Console.WriteLine(findBook1.GetTitle());
    var findBook2 = library.GetBook("111111");
    Console.WriteLine(findBook2.GetTitle());


}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
catch(IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch(BookNotFoundException e)
{
    Console.WriteLine(e.GetMessage());
}
finally
{
    Console.WriteLine("It's nice to see you here again.");
}


Console.ReadLine();
