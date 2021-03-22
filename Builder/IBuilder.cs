using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        void setId(string id);
        void setFirstName(string firstName);
        void setLastName(string lastName);
        void setDayOfBirth(string day);
        void setCurrentClass(string currentClass);
        void setAddress(string address);
        void setPhone(string phone);

        Student build();
    }
}
