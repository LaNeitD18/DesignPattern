using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class StudentBuilder : IBuilder
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

        public void setAddress(string address)
        {
            this._student.Address = address;
        }

        public void setCurrentClass(string currentClass)
        {
            this._student.CurrentClass = currentClass;
        }

        public void setDayOfBirth(string day)
        {
            this._student.DayOfBirth = day;
        }

        public void setFirstName(string firstName)
        {
            this._student.FirstName = firstName;
        }

        public void setId(string id)
        {
            this._student.Id = id;
        }

        public void setLastName(string lastName)
        {
            this._student.LastName = lastName;
        }

        public void setPhone(string phone)
        {
            this._student.Phone = phone;
        }

        public void buildStudentWithName(string first, string last)
        {
            setFirstName(first);
            setLastName(last);
        }

        
    }
}
