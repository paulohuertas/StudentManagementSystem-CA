using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Student
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int StudentNumber { get; set; }
        public Address address;
        public Course course;
        
        public Student() { }

        public Student(string fName, string surname, string email, string phone, int studentId)
        {
            FirstName = fName;
            Surname = surname;
            Email = email;
            Phone = phone;
            StudentNumber = studentId;
        }
    }
}
