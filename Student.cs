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
        private string id;
        private string birhtDate;
        private string phoneNumber;
        private string city;
        private string country;
        private string institution;
        private string institutionLocation;

        public Student(string id, string birthDate, string phoneNumber, string city, string country, string institution, string institutionLocation)
        { 
            this.id = id;
            this.birhtDate = birthDate;
            this.phoneNumber = phoneNumber;
            this.city = city;
            this.country = country;
            this.institution = institution;
            this.institutionLocation = institutionLocation;
        
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string BirhtDate
        {
            get
            {
                return birhtDate;
            }
            set
            {
                birhtDate = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
              public string Institutiun
        {
            get
            {
                return institution;
            }
            set
            {
                institution = value;
            }
        }
        public string InstitutionLocation
        {
            get
            {
                return institutionLocation;
            }
            set
            {
                institutionLocation = value;
            }
        }
        public void PrintValues()
        {
            Console.WriteLine($"ФИО: {id}, Контактный номер: {phoneNumber}, Дата рождения: {birhtDate}, Учебное учереждение: " +
                $"{institution}, Локация учебного череждения: {institutionLocation}");
        }
    }
}
