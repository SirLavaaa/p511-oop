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
            Sailor sailor = new Sailor("Dave", 38, "Capitan", 3);
            sailor.Work();
            sailor.Print();
            Tiger tiger = new Tiger("white", 6);
            tiger.Print();
            tiger.Sleep();
            Rectangle rectangle = new Rectangle(12.3, 13);
            rectangle.Area();
        }
    }
}
