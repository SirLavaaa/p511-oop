using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Person
    {
        public string _name {  get; set; }
        public string _age { get; set; }
        public Person(string name, string age)
        {  _name = name; _age = age;}
        public string Print()
        {
            return _name + " " + _age;
        }
    }
}
