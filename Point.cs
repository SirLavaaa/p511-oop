using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Point
    {
        private double x { get; set; }
        private double y { get; set; }
        private double z { get; set; }
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void PrintValues()
        {
            Console.WriteLine($"X: {x}, Y: {y}, Z: {z}");
        }
    }
}
