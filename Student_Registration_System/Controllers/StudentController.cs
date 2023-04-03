using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Registration_System.Models;
using Student_Registration_System.Repository;

namespace Student_Registration_System.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository _context;
        private StudentContext _stud;
        public StudentController(IStudentRepository context, StudentContext stud)
        {
            _context = context;
            _stud = stud;
        }
        public IActionResult GetAllStudents()
        {
            return View(_context.GetAllStudents());
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            ViewBag.Courses = new SelectList(_stud.Courses, "CourseName", "CourseName");
            ViewBag.Hobbies = new SelectList(_stud.Hobby, "HobbiesName", "HobbiesName");
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            Student student1 = _context.AddStudent(student);
            return RedirectToAction("GetAllStudents");
        }
        public IActionResult UpdateStudent(int id)
        {
            ViewBag.Courses = new SelectList(_stud.Courses, "CourseName", "CourseName");
            ViewBag.Hobbies = new SelectList(_stud.Hobby, "HobbiesName", "HobbiesName");
            Student student = _context.GetStudent(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
           if( _context.Update(student))
            {
                return RedirectToAction("GetAllStudents");
            }
            else { return View(); }
        }
        public IActionResult Delete(int id)
        {
            if (_context.DeleteStudent(id))
            {
                ViewData["Message"] = "Are you sure you want to delete this record ?";
                return RedirectToAction("GetAllStudents");
            }
            //return View();
            throw new NotImplementedException();
        }
        public int get_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.AddYears(-dob.Year).Year;
            return age;
        }
    }
}
