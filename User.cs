using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class User
    {
        private string name;
        private int age;

        public string getName()
        {
            return name;
        }

        public void setName(string value)
        { 
             name = value;
        }
        public int getAge()
        {
            return age;
        }

        public void setAge(int value)
        {
            age = value;
        }

    }
}
