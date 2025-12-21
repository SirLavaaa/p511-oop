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
            StudentManager students = new StudentManager();
            students.Add(new Student("Dave", 21, 4.2));
            students.Add(new Student("Jhon", 19, 5.0));
            students.Add(new Student("Mike", 21, 3.2));
            //students.Print();
            //students.SaveToFile(@"C:\Users\Student\Desktop\Student.txt");
            //students.LoadFromFile(@"C:\Users\Student\Desktop\Student.txt");
            Console.WriteLine("Что вы хотите сделать? \n1-добавить студент \n2-вывести на экран \n3-сохранить что-то \n4-загрузить файл");
            int draft = Convert.ToInt32(Console.ReadLine());
            if (draft == 1)
                students.Add(new Student(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
            else if (draft == 2)
                students.Print();
            else if (draft == 3)
                students.SaveToFile(Console.ReadLine());
            else if (draft == 4)
                students.LoadFromFile(Console.ReadLine());
            else if (draft == 0)
                Console.WriteLine("Program End");
            else
                Console.WriteLine("Error");
        }
        
    }
}
