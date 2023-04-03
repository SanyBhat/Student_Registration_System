using System.ComponentModel.DataAnnotations;

namespace Student_Registration_System.Models
{
    public class Course
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string CourseName { get;set; }
    }
}
