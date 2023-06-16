using System.Reflection;

namespace LibrarySystem
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _year;
        private string _description;
        private string _genre;

        public string Title 
        { 
            get
            {
                return _title;
            }
            set 
            { 
                _title = value;
                
            }
        }

        public string Author
        {
            get 
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string Description 
        { 
            get 
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }
    }
}