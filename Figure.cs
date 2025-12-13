using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Figure
    {
        protected Figure() 
        { 
        }
        public abstract void Area();
    }
    class Rectangle : Figure
    {
        private double _a {  get; set; }
        private double _b { get; set; }
        public Rectangle(double a, double b)
        { 
          _a = a;
          _b = b;
        }
        public override void Area()
        {
            Console.WriteLine(_a * _b);
        }
    }
    class Circle: Figure
    {
        private double _r { get; set; }
        public Circle (double r)
        {
            _r = r;
        }
        public override void Area()
        {
            Console.WriteLine(_r * _r * 3.14);
        }
    }
    class Trinagle : Figure
    {
        private double _a { get; set; }
        private double _b { get; set; }
        public Trinagle(double a, double b)
        {
            _a = a;
            _b = b;

        }
        public override void Area()
        {
            Console.WriteLine(_a * _b / 2);
        }
    }
    class Trapezoid : Figure
    {
        private double _a { get; set; }
        private double _b { get; set; }
        private double _h { get; set; }
        public Trapezoid(double a, double b, double h)
        { 
            _a = a;
            _b = b;
            _h = h;

        }
        public override void Area()
        {
            Console.WriteLine((_a + _b)/ 2 * _h);
        }
    }
}
