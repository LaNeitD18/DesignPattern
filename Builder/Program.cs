using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBuilder studentBuilder = new StudentBuilder();

            studentBuilder.setFirstName("Tieens");
            studentBuilder.setLastName("Phan");
            studentBuilder.setPhone("090");

            Student s = studentBuilder.build();

            Console.WriteLine("Name: " + s.LastName + " " + s.FirstName);
            Console.WriteLine("Phone: " + s.Phone);
        }
    }
}
