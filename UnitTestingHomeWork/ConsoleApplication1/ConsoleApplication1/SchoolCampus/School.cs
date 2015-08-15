

namespace SchoolCampus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class School
    {
        public School(ICollection<Student> students, ICollection<Course> courses)
        {
            this.Students = students;
            this.Courses = courses;
        }

        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }


    }
}
