using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class StudentManager
    {
        List<Student> _students = new List<Student>();
        public StudentManager() {}
       
        public void Print()
        {
            foreach (Student student in _students)
            {
                Console.WriteLine(student);
            }
        }
        public void Add(Student student)
        {
            _students.Add(student);
        }
        public void SaveToFile(string path)
        {
            try
            {
                using (StreamWriter studentWriter = new StreamWriter(path))
                {
                    foreach (Student student in _students)
                    {
                        studentWriter.WriteLine(student);
                    }
                }
            }
             catch (FormatException ex)
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
        }
        public void LoadFromFile(string path)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("неизвестная ошибка");
            }
        }

    }
}
