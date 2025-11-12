using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Rectangle
    {
        public double width;
        public double height;
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
        public void SetVaules(double _width, double _height)
        {
            width = _width;
            height = _height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetVaules(16.3, 12);
            double area = rect.GetArea();
            Console.WriteLine(area);
            double perim = rect.GetPerimeter();
            Console.WriteLine(perim);
        }
    }
}
