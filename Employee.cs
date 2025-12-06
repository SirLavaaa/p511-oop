using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Employee
    {
        private string _firstName {  get; set; }
        private string _lastName { get; set; }
        private string _birthDate { get; set; }
        private string _phoneNumber { get; set; }
        private string _email { get; set; }
        private string _post {  get; set; }
        private string _description { get; set; }

        public Employee(string firstName, string lastName, string birthDate, string phoneNumber, string email, string post, string description)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
            _phoneNumber = phoneNumber;
            _email = email;
            _post = post;
            _description = description;
        }
        public void GetEmployeeValues()
        {
            _firstName = Console.ReadLine();
            _lastName = Console.ReadLine();
            _birthDate = Console.ReadLine();
            _phoneNumber = Console.ReadLine();
            _email = Console.ReadLine();
            _post = Console.ReadLine();
            _description = Console.ReadLine();
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"ФИО: {_firstName} {_lastName},Дата рождения {_birthDate} ,номер телефона {_phoneNumber}, " +
                $"почта {_email},должность {_post},описание должности {_description}");
        }

    }
}
