using Abp.School.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abp.School.Core.Models
{
    /// <summary>
    /// 选课表，中间关联表
    /// </summary>
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        /// <summary>
        /// 课程评分
        /// </summary>
        public CourseGrade? Grade { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}
