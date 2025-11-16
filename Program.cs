using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    public class Rectangle
    {
        private double width;
        private double height;
        
        public Rectangle(double widht , double height)
        {
            Width = widht;
            Height = height;
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ошибка, какое-то значение меньше 0");
                }
            }
        }
        public double Height
        {
            get
            { 
                return height; 
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка, какое-то значение меньше 0");
                }
            }
        }   


        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(17.2 , 12.6);
            Console.WriteLine(rect1.GetArea());
            Console.WriteLine(rect1.GetPerimeter());
            
            Rectangle rect2 = new Rectangle(-11, 12);
            Console.WriteLine($"Widt rect2 = {rect2.Width}");
            Console.WriteLine($"Height rect2 = {rect2.Height}");
        }
    }
}
