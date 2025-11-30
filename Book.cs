using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Book
    {
        public string _author {  get; set; }
        public string _title { get; set; }
        public string _publisher { get; set; }
        public int _year { get; set; }
        public int _pageNumbers { get; set; }

        public Book(string author, string title, string publisher, int year, int pageNumbers)
        {
            _author = author;
            _title = title;
            _publisher = publisher;
            _year = year;
            _pageNumbers = pageNumbers;
        }
        public void Print()
        {
            Console.WriteLine($"Author: {_author}, Title: {_title}, Publisher: {_publisher} Year: {_year} Page: {_pageNumbers}");
        }
    }
}
