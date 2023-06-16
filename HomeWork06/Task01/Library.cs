using LibrarySystem;

public class Library
{
    private Book[] _books;
    private int _count;

    public Book[] getBooks()
    {
        return _books;
    }
    public void setBooks(Book[] books)
    {
        _books = books;
    }

    public Book this[int i]
    {
        get { return _books[i]; }
        set { _books[i] = value; }
    }

    public int Count
    {
        get
        {
            return _books.Length;
        }
    }

    public void AddBook(Book book)
    {
        Array.Resize(ref  _books, _books.Length + 1);
        _books[_books.Length - 1] = book;
    }

    public void RemoveBook(int i)
    {
        if(i >= this.Count)
        {
            Console.WriteLine("Index is out of bounds");
            return;
        }
        
        Book[] newBooks = new Book[this.Count - 1];
        for (int j = 0; j < this.Count; j++)
        {
            if(j == i)
            {
                continue;
            }
            {
                newBooks[newBooks.Length-1] = _books[j];
            }
        }
        this.setBooks(newBooks);
    }

    public Book[] FindBooks(string title = "", string author = "", int year = 0, string description = "", string genre = "")
    {
        Book[] searchedBooks = new Book[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            if ((title == "" || title == _books[i].Title)
                    && (author == "" || author == _books[i].Author)
                    && (year == 0 || year == _books[i].Year)
                    && (description == "" || description == _books[i].Description)
                    && (genre == "" || genre == _books[i].Genre))
            {

                searchedBooks[searchedBooks.Length] = _books[i];

            }
        }

        return searchedBooks;
    }

}