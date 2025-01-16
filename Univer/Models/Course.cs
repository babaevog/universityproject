using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string Title { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
