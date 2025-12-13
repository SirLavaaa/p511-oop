using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Human
    {
        protected string _name {  get; set; }
        protected int _age { get; set; }
        protected Human(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public abstract void Print();
        public abstract void Work();
    }
    class Builder : Human
    {
        private string _post { get; set; }
        private double _experience { get; set; }
        public Builder(string name, int age, string post, double experience) : base(name, age)
        { 
            _post = post;
            _experience = experience;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Post: {_post}, Experience: {_experience}");
        }
        public override void Work()
        {
            Console.WriteLine($"{_name} строит здание");
        }
    }
    class Sailor : Human
    {
        private string _post { get; set; }
        private double _experience { get; set; }
        public Sailor(string name, int age, string post, double experience) : base(name, age)
        {
            _post = post;
            _experience = experience;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Post: {_post}, Experience: {_experience}");
        }
        public override void Work()
        {
            Console.WriteLine($"{_name} плывёт");
        }
    }
    class Pilot: Human
    {
        private string _post { get; set; }
        private double _experience { get; set; }
        public Pilot(string name, int age, string post, double experience) : base(name, age)
        {
            _post = post;
            _experience = experience;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Post: {_post}, Experience: {_experience}");
        }
        public override void Work()
        {
            Console.WriteLine($"{_name} летит");
        }
    }
}
