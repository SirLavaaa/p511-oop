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
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory(1, "rice", 10),
                new Inventory(2, "bread", 30)
            };
            Console.WriteLine("введите id товара");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Inventory item in inventories)
            {
                if(item._id == id)
                   item.Print();
            }
        }
    }
}
