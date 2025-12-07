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
            Student student = new Student("Nick", 19,"987231793", "A@gmail.com", "p511");
            student.PrintStudent();
            Aspirant aspirant = new Aspirant("Nick", 19, "987231793", "A@gmail.com", "p511", "work");
            aspirant.PrintStudent();
        }
    }
}
