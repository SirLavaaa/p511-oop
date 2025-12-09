using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Inventory
    {
        public int _id {  get; set; }
        private string _name { get; set; }
        private double _price { get; set; }
        public Inventory(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }
        public void Print()
        {
            Console.WriteLine($"ID: {_id}, Name: {_name}, Price: {_price}");
        }
    }
}
