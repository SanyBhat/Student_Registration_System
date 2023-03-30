using NuGet.Protocol.Plugins;
using Student_Registration_System.Models;

namespace Student_Registration_System.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();

        bool AddStudent(Student student);
        bool UpdateStudent(int studid);
        bool DeleteStudent(int studid);
    }
}
