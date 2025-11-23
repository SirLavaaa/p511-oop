using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Phone
    {
        private string brand;
        private string model;
        private double price;

        public Phone(string brand, string model, double price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }

        public string Brand
        {
            get
            { 
                return brand; 
            }
            set
            {
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                brand = model;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Price: {price}");
        }
    }
}
