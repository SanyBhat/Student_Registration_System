using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Registration_System.Models
{
    public class Hobbies
    {
        [Key]
        [Required]
        public string HobbiesName { get; set; }
    }
}
