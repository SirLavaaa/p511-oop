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
            students.Print();
            students.SaveToFile(@"C:\Users\Student\Desktop\Student.txt");
            students.LoadFromFile(@"C:\Users\Student\Desktop\Student.txt");
        }
    }
}
