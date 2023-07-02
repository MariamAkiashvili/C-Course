using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    public class Library
    {
        private List <Book> _books;
        public static int _capacity;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book", "Can't Add Empty Value to Library");
            }
            else
            {
                if ((_books.Count + 1) <= _capacity)
                {
                    _books.Add(book);
                }
                else
                {
                    throw new IndexOutOfRangeException("Can't add an extra book");
                }
            }
        }

        public List <Book> GetBookList()
        {
            return _books;
        }

        public Book GetBook(string number)
        {
            List <Book> books = _books.Where(item => item.GetNumber() == number).ToList();
            BookNotFoundException exc = new BookNotFoundException("Book doesn't exist with the number: "+ number);
            if(books.Count == 0)
            {
                throw exc;
            }else
            {
                return books[0];
            }
        }

    }
}
