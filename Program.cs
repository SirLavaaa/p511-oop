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
            Student student = new Student("Иван","Иванов", 19, "+7-777-777-77-77" , "Тюмень" , 
                "Россия" , "Тюменский Индустриальный Университет" , "Тюмень, Россия");
                student.PrintValues();
            student.FullName();
            Student student2 = new Student("Иван", "Иванов", 198, "+7-777-777-77-77", "Тюмень",
                "Россия", "Тюменский Индустриальный Университет", "Тюмень, Россия");
            student2.PrintValues();

        }
    }
}
