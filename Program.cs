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
            try
            {
                int age = -1;
                if (age < 0)
                {
                    throw new ArgumentException("Возвраст не может быть отрицательным");
                }
                Console.WriteLine(age);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentException e)
            { 
                Console.WriteLine("неизвестная ошибка");
            }
            finally
            {
                Console.WriteLine("Операция завершина");
            }

            try
            {
                int[] nums = new int[5] { 1, 2, 3, 4, 5 };
                Console.WriteLine(nums[6]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Операция завершена");
            }
        }
    }
}
