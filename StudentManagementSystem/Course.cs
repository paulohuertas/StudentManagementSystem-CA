using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Course
    {
        public LevelEnum Level { get; set; }
        public CourseEnum Courses { get; set; }

        public Course() { }

        public Course(LevelEnum level, CourseEnum courses)
        {
            Level = level;
            Courses = courses;
        }
    }
}
