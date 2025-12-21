using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Student
    {
        private string _name {  get; set; }
        private int _age { get; set; }
        private double _avgGrade { get; set; }
        public Student(string name, int age, double avgGrade)
        {
            _age = age;
            _name = name;
            _avgGrade = avgGrade;
        }
        public override string ToString()
        {
            return $"{_name} {_age} {_avgGrade}";
        }
    }
}
