using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Registration_System.Models
{
    public class Hobbies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string HobbieName { get; set; }
    }
}
