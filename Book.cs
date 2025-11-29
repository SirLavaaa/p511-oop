using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Book
    {
        private string _author {  get; set; }
        private string _title { get; set; }
        private string _publisher { get; set; }
        private string _year { get; set; }
        private int _pageNumbers { get; set; }

        public Book(string author, string title, string publisher, string year, int pageNumbers)
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
