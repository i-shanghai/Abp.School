
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abp.School.Core.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string StuName { get; set; } 

        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
