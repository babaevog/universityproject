using Univer.Models;
using UniversityProject.Models;

namespace Univer.Data
{
    public static class DbInnit
    {
        public static void Initialized(SchoolContext context)
        {
            if (context.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student { LastName = "Tinkoff", FirstName = "Oleg", EnrollmentDate = DateTime.Parse("2010-04-22") },
                new Student {LastName = "Cook",FirstName = "Tim",EnrollmentDate=DateTime.Parse("1988-09-1")},
                new Student {LastName = "Ive",FirstName = "Jony",EnrollmentDate=DateTime.Parse("1968-09-1")},
            };
            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course {CourseId=100,Title="Economy"}
                
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[] 
            {
                new Enrollment{StudentId = 1, CourseID=100,Grade=Grade.Good}
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    } 
}
