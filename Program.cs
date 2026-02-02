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
            Manager manager = new Manager("bob", 100000, 10000);
            manager.CalculateMonthlySalary();
        }
    }
}
