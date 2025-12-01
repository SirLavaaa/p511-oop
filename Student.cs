using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Student
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private int age { get; set; }
        private string phoneNumber { get; set; }
        private string city { get; set; }
        private string country { get; set; }
        private string institution { get; set; }
        private string institutionLocation { get; set; }

        public Student(string firstName, string lastName, int age, string phoneNumber, string city, string country, string institution, string institutionLocation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.city = city;
            this.country = country;
            this.institution = institution;
            this.institutionLocation = institutionLocation;

        }

        public void PrintValues()
        {
            if (this.age > 0 && this.age < 150)
                Console.WriteLine($"ФИО: {firstName} {lastName}, Контактный номер: {phoneNumber}, Возраст: {age}, Учебное учереждение: " +
                $"{institution}, Локация учебного череждения: {institutionLocation}");
            else
                Console.WriteLine("Ошибка");
             
        }
        public void FullName()
        {
            Console.WriteLine($"FullName {firstName} {lastName}");
        }
    }
}
