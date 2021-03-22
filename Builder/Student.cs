using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Student
    {
        private string id;
        private string firstName;
        private string lastName;
        private string dayOfBirth;
        private string currentClass;
        private string address;
        private string phone;

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public string CurrentClass { get => currentClass; set => currentClass = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }

        public Student() { }

        //public Student(string id, string firstName, string lastName, string dayOfBirth, 
        //    string currentClass, string address, string phone)
        //{
        //    this.id = id;
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.dayOfBirth = dayOfBirth;
        //    this.currentClass = currentClass;
        //    this.address = address;
        //    this.phone = phone;
        //}

        //public Student(string id, string firstName, string lastName)
        //{
        //    this.id = id;
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //}

        //public Student(string id, string currentClass, string address, string phone)
        //{
        //    this.id = id;
        //    this.currentClass = currentClass;
        //    this.address = address;
        //    this.phone = phone;
        //}

    }
}
