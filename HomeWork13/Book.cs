using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    public class Book
    {
        public string _number;
        public string _title;
        public string _author;


        public Book(string number, string title, string author)
        {
            if(number  == "" || title == "" || author == "")
            {
                throw new ArgumentNullException("Book" , "Please fill all field");
            }
            else
            {
                this._number = number;
                this._title = title;
                this._author = author;
            }
        }

        public string GetNumber()
        {
            return _number;
        }
        public string GetTitle() 
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
        }



    }
}
