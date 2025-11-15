using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace p511_oop
{

    class User
    {
        public string name;
        public string surename;
        public int age;
        public string city;

        public User(string name, string surename, int age, string city) 
        { 
          this.name = name;
          this.surename = surename;
          this.age = age;
          this.city = city;
        }
        public void getVaules()
        {
            Console.WriteLine($"name {name}, age {age}, city {city}, surename {surename}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Alex", "Morgan", 17, "New York");
            user.getVaules();
        }
    }
}
