using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kai", "19");
            person.ToString();
            StreamWriter streamWriter = null;
            StreamReader streamReader = null;
            try
            {
                using (streamWriter = new StreamWriter(@"C:\Users\Student\Desktop\Person.txt", append: false, encoding: Encoding.UTF8))
                {
                    streamWriter.WriteLine(person.Print());
                    Console.WriteLine("Данные успешно записаны");
                }
            }
            catch (UnauthorizedAccessException ex)
            { 
              Console.WriteLine(ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("неизвестная ошибка");
            }
            try
            {
                using (streamReader = new StreamReader(@"C:\Users\Student\Desktop\Person.txt"))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                   
            }
            catch(Exception e) 
            {
                Console.WriteLine("неизвестная ошибка");
            }
            
        }
    }
}
