using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder<T>
    {
        T setId(string id);
        T setFirstName(string firstName);
        T setLastName(string lastName);
        T setDayOfBirth(string day);
        T setCurrentClass(string currentClass);
        T setAddress(string address);
        T setPhone(string phone);

        Student build();
    }
}
