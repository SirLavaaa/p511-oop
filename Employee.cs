using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Employee
    {
        protected string _name {  get; set; }
        protected double _baseSalary { get; set; }
        public Employee(string name, double baseSalary)
        {
            _name = name;
            _baseSalary = baseSalary;
        }
        public virtual void CalculateMonthlySalary()
        {
            Console.WriteLine(_baseSalary);
        }
    }
    class Manager: Employee
    {
        private double _bonus {  get; set; }
        public Manager(string name, double baseSalary, double bonus): base(name, baseSalary)
        {
            _bonus = bonus;
        }
        public override void CalculateMonthlySalary()
        {
            Console.WriteLine(_baseSalary + _bonus);
        }
    }
    class Developer : Employee
    {
        private int _linesOfCodeWritten { get; set; }
        public Developer(string name, double baseSalary, int linesOfCodeWritten) : base(name, baseSalary)
        {
            _linesOfCodeWritten = linesOfCodeWritten;
        }
        public override void CalculateMonthlySalary()
        {
            Console.WriteLine(_baseSalary + (_linesOfCodeWritten * 0.01));
        }
    }
}
