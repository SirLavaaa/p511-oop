using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book("Stephan King", "it", "N", 1987, 378),
                new Book("Stephan King", "Shine", "F", 1985, 389),
                new Book("Alexandr Pushkin", "Capitan Daughter", "N", 1875, 143)
            }; 
            Console.WriteLine("Введите автора");
            string author = Console.ReadLine();
            Console.WriteLine("Найденные книги");

            foreach (Book book in books)
            {
                if (book._author == author)
                {
                    book.Print();
                }
            }
            Console.WriteLine("Введите издателя");
            string publisher = Console.ReadLine();
            Console.WriteLine("Найденные книги");

            foreach (Book book in books)
            {
                if (book._publisher == publisher)
                {
                    book.Print();
                }
            }
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Найденные книги");

            foreach (Book book in books)
            {
                if (book._year >= year)
                {
                    book.Print();
                }
            }
        }
    }
}
