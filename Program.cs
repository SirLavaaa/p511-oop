using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace p511_oop
{
    internal class Program
    {
        static int Factorial(int n)
        {
            int b = 1;
            for (int i = 1; i <= n; i++)
            {
                b *= i;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine(Factorial(number));
        }
    }
}
