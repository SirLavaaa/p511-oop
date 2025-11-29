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
         Book book = new Book("Stephan King", "IT", "N", "1987", 356 );
            book.Print();
        }
    }
}
