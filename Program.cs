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
            Employee employee = new Employee("Иван", "Иванов", "08.11.2005", "77777777777", "pochta1234@gmail.ru", "продавец", "Продаёт");
            employee.PrintEmployee();
            Plane plane = new Plane("Boing 700", "Boing", 2017, "пассажирский");
            plane.PrintPlane();
        }
    }
}
