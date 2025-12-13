using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Figure
    {
        protected double _a { get; set; }
        protected double _b { get; set; }
        protected Figure(double a, double b) 
        { 
            _a = a;
            _b = b;
        }
        public abstract void Area();
    }
    class Rectangle : Figure
    {
        public Rectangle(double a, double b): base(a, b) { }
        public override void Area()
        {
            Console.WriteLine(_a * _b);
        }
    }
    class Circle: Figure
    {
        private int _r { get; set; }
        public Circle (double a, double b, double r) : base(a, b) { }
        public override void Area()
        {
            Console.WriteLine(_r * _r * 3.14);
        }
    }
    class Trinagle : Figure
    {
        public Trinagle(double a, double b) : base(a, b) { }
        public override void Area()
        {
            Console.WriteLine(_a * _b / 2);
        }
    }
    class Trapezoid : Figure
    {
        private double _h { get; set; }
        public Trapezoid(double a, double b, double h) : base(a, b) { }
        public override void Area()
        {
            Console.WriteLine((_a + _b)/ 2 * _h);
        }
    }
}
