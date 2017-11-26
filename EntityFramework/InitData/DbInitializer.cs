using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.School.Core.Models;
using Abp.School.Application.ViewModels;

namespace Abp.School.EntityFramework.InitData
{
    public class DbInitializer
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="context"></param>
        public static void Initialize(SchoolDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            //Student
            var students = new Student[] {

                new Student{ Id=1,StuName="小王",EnrollmentDate=Convert.ToDateTime("2017-09-09")},
                new Student{ Id=2,StuName="小李",EnrollmentDate=Convert.ToDateTime("2017-09-09")},
                new Student{ Id=3,StuName="小张",EnrollmentDate=Convert.ToDateTime("2017-09-09")},
                new Student{ Id=4,StuName="小刘",EnrollmentDate=Convert.ToDateTime("2017-09-09")},
                new Student{ Id=5,StuName="小陈",EnrollmentDate=Convert.ToDateTime("2017-09-09")}
            };
            foreach (Student item in students)
            {
                context.Students.Add(item);
            }
            context.SaveChanges();

            //Course 
            var courses = new Course[] {
                new Course{ ID=2001,Title="语文",Credits=3},
                new Course{ ID=2002,Title="英语",Credits=3},
                new Course{ ID=2003,Title="政治",Credits=4},
                new Course{ ID=2004,Title="生物",Credits=4},
                new Course{ ID=2005,Title="历史",Credits=5}
            };
            foreach (Course item in courses)
            {
                context.Courses.Add(item);
            }
            context.SaveChanges();

            //Enrollment

            //Course 
            var Enrollments = new Enrollment[] {
                new Enrollment{EnrollmentId=5001,StudentId=1,CourseId=2001,Grade=CourseGrade.A},
                new Enrollment{EnrollmentId=5002,StudentId=2,CourseId=2002,Grade=CourseGrade.B },
                new Enrollment{EnrollmentId=5003,StudentId=3,CourseId=2003,Grade=CourseGrade.C},
                new Enrollment{EnrollmentId=5004,StudentId=4,CourseId=2004,Grade=CourseGrade.D },
                new Enrollment{EnrollmentId=5005,StudentId=5,CourseId=2005,Grade=CourseGrade.E }
            };
            foreach (Enrollment item in Enrollments)
            {
                context.Enrollments.Add(item);
            }
            context.SaveChanges();
        }

    }
}
