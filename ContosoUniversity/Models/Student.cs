using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentLastName { get; set; }
        public string StudentMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
