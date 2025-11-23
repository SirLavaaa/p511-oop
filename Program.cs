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
           Phone phone = new Phone("Samsumg" , "S23" , 50000);
            phone.Print();
        }
    }
}
