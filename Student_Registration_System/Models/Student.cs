using System.ComponentModel.DataAnnotations;

namespace Student_Registration_System.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public  DateTime DateOfBirth { get; set; }
        public string? CourseName { get; set; }
        public Course? Course { get; set; }
        public List<Hobbies>? Hobbies { get; set; }
    }
}
