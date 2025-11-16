using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace p511_oop
{

    class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        

        public Student(string firstName, string lastName, int age) 
        { 
          this.firstName = firstName;
          this.lastName = lastName;    
          this.age = age;
        }
        public void Introduce()
        {
            Console.WriteLine($"Привет, я {firstName} {lastName}, мне {age}");
        }
    }
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
