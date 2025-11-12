using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 1 число");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите 2 число");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("какую опреацию хотите провести? 1 - +; 2 - -; 3 - *; 4 - /");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
                Console.WriteLine(numberOne + numberTwo);
            else if (a == 2) 
                Console.WriteLine(numberOne - numberTwo);
            else if (a == 3)
                Console.WriteLine(numberOne * numberTwo);
            else if (a == 4)
                Console.WriteLine(numberOne / numberTwo);
            else
                Console.WriteLine("ошибка");

        }
    }
}
