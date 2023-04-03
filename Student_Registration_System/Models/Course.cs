using System.ComponentModel.DataAnnotations;

namespace Student_Registration_System.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        public string CourseName { get;set; }
    }
}
