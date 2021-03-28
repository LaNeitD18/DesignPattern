using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class StudentBuilder : IBuilder<StudentBuilder>
    {
        private Student _student = null;
        public StudentBuilder()
        {
            this.reset();
        }

        private void reset()
        {
            this._student = new Student();
        }

        public Student build()
        {
            Student res = this._student;

            this.reset();

            return res;
        }

        public StudentBuilder setAddress(string address)
        {
            this._student.Address = address;
            return this;
        }

        public StudentBuilder setCurrentClass(string currentClass)
        {
            this._student.CurrentClass = currentClass;
            return this;
        }

        public StudentBuilder setDayOfBirth(string day)
        {
            this._student.DayOfBirth = day;
            return this;
        }

        public StudentBuilder setFirstName(string firstName)
        {
            this._student.FirstName = firstName;
            return this;
        }

        public StudentBuilder setId(string id)
        {
            this._student.Id = id;
            return this;
        }

        public StudentBuilder setLastName(string lastName)
        {
            this._student.LastName = lastName;
            return this;
        }

        public StudentBuilder setPhone(string phone)
        {
            this._student.Phone = phone;
            return this;
        }
        
    }
}
