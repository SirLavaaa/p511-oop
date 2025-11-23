using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           User user = new User();
            user.setName("Jhon");
            user.setAge(18);
            Console.WriteLine(user.getName());
            Console.WriteLine(user.getAge());
        }
    }
}
