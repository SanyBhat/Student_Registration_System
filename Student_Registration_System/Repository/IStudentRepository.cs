using NuGet.Protocol.Plugins;
using Student_Registration_System.Models;

namespace Student_Registration_System.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student AddStudent(Student student);
        Student GetStudent(int id);
        bool Update(Student student);
        bool DeleteStudent(int studid);
    }
}
