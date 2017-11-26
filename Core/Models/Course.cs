using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abp.School.Core.Models
{
    public class Course
    {
        public int ID { get; set; }

        /// <summary>
        /// 课程名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 课程学分
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// 选课学生
        /// </summary>
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
