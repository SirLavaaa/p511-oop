using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Transport
    {
        protected int _priceForS { get; set; }
        protected int _capacity { get; set; }
        protected double _maxWeight { get; set; }
        protected double _speed { get; set; }
        protected Transport(int priceForS, int capacity, int maxWeight, double speed)
        {
            _priceForS = priceForS;
            _capacity = capacity;
            _maxWeight = maxWeight;
            _speed = speed;
        }
        public abstract void Time(double s);
        public abstract void Price(double s, int passengers, double cargo);
    }
    class Car: Transport
    {
        public Car(): base(500, 5,350, 120 ){}
        public override void Time(double s)
        {
           if (s > 0)
            Console.WriteLine(s / _speed);
            else
                Console.WriteLine("erorr");
        }
        public override void Price(double s, int passengers, double cargo)
        {
            if (passengers <= _capacity && cargo <= _maxWeight)
                Console.WriteLine((s + _priceForS) + (passengers * 100) + (cargo * 50));
            else
               Console.WriteLine("erorr");
        }
    }
    class Bike : Transport
    {
        public Bike() : base(100, 2, 50, 20) { }
        public override void Time(double s)
        {
            if (s > 0)
                Console.WriteLine(s / _speed);
            else
                Console.WriteLine("erorr");
        }
        public override void Price(double s, int passengers, double cargo)
        {
            if (passengers <= _capacity && cargo <= _maxWeight)
                Console.WriteLine((s + _priceForS) + (passengers * 100) + (cargo * 50));
            else
                Console.WriteLine("erorr");
        }
    }
    class Carriage : Transport
    {
        public Carriage() : base(40, 1, 30, 10) { }
        public override void Time(double s)
        {
            if (s > 0)
                Console.WriteLine(s / _speed);
            else
                Console.WriteLine("erorr");
        }
        public override void Price(double s, int passengers, double cargo)
        {
            if (passengers <= _capacity && cargo <= _maxWeight)
                Console.WriteLine((s + _priceForS) + (passengers * 100) + (cargo * 50));
            else
                Console.WriteLine("erorr");
        }
    }
}
