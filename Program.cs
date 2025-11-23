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
            Student studentOne = new Student("Пётр" ,"Петров" , 19);
            Student studentTwo = new Student("Илья" ,"Сидоров" , 21);
            Student studentThree = new Student("Иван" ,"Иванов" , 17);
            studentOne.Introduce();
            studentTwo.Introduce();
            studentThree.Introduce();


        }
    }
}
