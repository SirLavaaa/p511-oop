using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Animal
    {
        protected string _name { get; set; }
        public Animal(string name)
        {
            _name = name;
        }
        public virtual void Eat()
        {
            Console.WriteLine("животеное ест");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }
        public override void Eat()
        {
            Console.WriteLine($"{_name} ест");
        }
    }
    class Cat:Animal
    {
        public Cat(string name) : base(name)
        {

        }
    }
}
