using Student_Registration_System.Models;
using static Student_Registration_System.Repository.StudentRepository;

namespace Student_Registration_System.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext _context;

        public StudentRepository(StudentContext context)
        {
                _context = context;
        }
        public IEnumerable<Student> GetAllStudents()
        {

        }
        public bool AddStudent(Student student)
        {
           
        }

        public bool DeleteStudent(int studid)
        {
            
        }

        public bool UpdateStudent(int studid)
        {
           
        }
    }
}
