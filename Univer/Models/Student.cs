﻿using UniversityProject.Models;

namespace Univer.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public DateTime EnrollmentDate { get; set; }
        //public ICollection<Enrollment> Enrollments { get; set; }

    }

}
