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
            Student student = new Student("Иванов Иван Иванович", "08.11.2006", "+7-777-777-77-77" , "Тюмень" , 
                "Россия" , "Тюменский Индустриальный Университет" , "Тюмень, Россия");
                student.PrintValues();
            
        }
    }
}
