using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText(@"C:\Users\Student\Desktop\hi.txt", "\nbye");
            string text = File.ReadAllText(@"C:\Users\Student\Desktop\hi.txt");
            Console.WriteLine(text);
        }
    }
}
