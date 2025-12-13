using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Animal
    {
        protected string _species { get; set; }
        protected int _age { get; set; }
        protected Animal(string specias, int age) 
        { 
            _species = specias;
            _age = age;
        }
        public abstract void Print();
        public abstract void Sleep();
    }
    class Tiger : Animal
    {
        public Tiger(string specias, int age) : base(specias, age) { }
        public override void Print()
        {
            Console.WriteLine($"specias: {_species}, Age: {_age}");
        }
        public override void Sleep()
        {
            Console.WriteLine("Tiger sleep");
        }
    }
    class Crocodile : Animal
    {
        public Crocodile(string specias, int age) : base(specias, age) { }
        public override void Print()
        {
            Console.WriteLine($"specias: {_species}, Age: {_age}");
        }
        public override void Sleep()
        {
            Console.WriteLine("Crocodile sleep");
        }
    }
    class Kangaroo: Animal
    {
        public Kangaroo(string specias, int age) : base(specias, age) { }
        public override void Print()
        {
            Console.WriteLine($"specias: {_species}, Age: {_age}");
        }
        public override void Sleep()
        {
            Console.WriteLine("Kangaroo sleep");
        }
    }
}
