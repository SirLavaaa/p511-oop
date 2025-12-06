using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Plane
    {
        private string _name {  get; set; }
        private string _brand {  get; set; }
        private int _year {  get; set; }
        private string _type {  get; set; }
        public Plane(string name, string brand, int year, string type)
        { 
             _name = name;
            _brand = brand;
            _year = year;
            _type = type;
        }
        public void GetPlaneValues()
        {
            _name = Console.ReadLine();
            _brand = Console.ReadLine();
            _year = Convert.ToInt32(Console.ReadLine());
            _type = Console.ReadLine();
        }
        public void PrintPlane()
        {
            Console.WriteLine($"Название {_name}, Производитель {_brand},Год выпуска {_year},Тип {_type}");
        }
    }
}
