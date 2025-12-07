using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Student
    {
        protected string _name {  get; set; }
        protected int _age {  get; set; }
        protected string _phoneNumber {  get; set; }
        protected string _email { get; set; }
        protected string _group { get; set; }

        public Student(string name, int age, string phoneNumber, string email, string group) 
        {
            _age = age;
            _phoneNumber = phoneNumber;
            _email = email;
            _group = group;
            _name = name;
        }
        public virtual void PrintStudent()
        {
            Console.WriteLine($"name: {_name}, age: {_age}, phone: {_phoneNumber}, email: {_email}, group: {_group}");
        }
    }
    class Aspirant : Student
    {
        private string _work { get; set; }
        public Aspirant(string name, int age, string phoneNumber, string email, string group, string work) : base(name, age, phoneNumber, email, group)
        {
            _work = work;
        }
        public override void PrintStudent()
        {
            Console.WriteLine($"name: {_name}, age: {_age}, phone: {_phoneNumber}, email: {_email}, group: {_group}, work: {_work}");
        }
    }
}
