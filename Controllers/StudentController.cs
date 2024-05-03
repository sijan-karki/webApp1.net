using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApp1BySijan.Models;

namespace WebApp1BySijan
{
    public class StudentController : Controller
    {
        Student s = new Student()
        {
            StdID = 12,
            Name = "Sagar Ale",
            Address = "123 sivaylayaTol",
            Faculty = "Computer Science"
        };
        public IActionResult MyRazorPage()
        {
            return View(s);
        }
        public IActionResult CreateStudentRecord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudentRecord(Student s)
        {
            if (ModelState.IsValid)
                return View("StudentDetail", s);
            else
                return View(s);
        }

        public IActionResult StudentDetail()
        {
            return View(s);
        }
    }
}
