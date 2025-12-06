using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Matrix
    {
        private int[,] _matrix {  get; set; }
        public Matrix(int[,] matrix)
        {
            _matrix = matrix;
        }
        public void PrintMatrix()
        {
            foreach (int el in _matrix)
            {
                Console.WriteLine(el);
            }
        }
        public void FindMax()
        {
            int max = _matrix[0, 0];
        }
    }
}
