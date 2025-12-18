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
            List<Document> documents = new List<Document>()
            {
                new TextDocument("Jhon", "Hello"),
                new ImageDocument("Dave", "900 * 900")
            };
            foreach (Document el in documents)
            {
                el.Render();
            }
        }
    }
}
