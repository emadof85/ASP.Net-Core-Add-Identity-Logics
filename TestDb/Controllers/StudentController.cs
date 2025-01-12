using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestDb.Controllers
{
      public class StudentController : Controller

      {
            private readonly StudentDbContext _context;
            public StudentController(StudentDbContext context)
            {
                  this._context = context;
            }

            // GET: StudentController
            public ActionResult Index()
            {
                  List<Student> students = _context.Students.Where(e => e.IsActive).ToList();
                  return View(students);
            }
            [HttpGet]
            public IActionResult Create()
            {
                  return View();
            }
            [HttpGet]
            public IActionResult Edit(int id)
            {
                  Student student = _context.Students.Find(id);
                  return View("Create", student);
            }




            [HttpPost]
            public IActionResult Create(Student student)
            {
                  try
                  {
                        if (student.Id == 0)
                        {
                              _context.Students.Add(student);
                              _context.SaveChanges();
                              return RedirectToAction("Index");
                        }
                        else
                        {
                              Student dbEntity = _context.Students.Find(student.Id);
                              dbEntity.FirstName = student.FirstName;
                              dbEntity.LastName = student.LastName;
                              dbEntity.Age = student.Age;
                              dbEntity.PhoneNumber = student.PhoneNumber;
                              dbEntity.StudentNumber = student.StudentNumber;
                              dbEntity.Password = student.Password;
                              _context.Students.Update(dbEntity);
                              _context.SaveChanges();
                              return RedirectToAction("Index");
                        }
                  }
                  catch (Exception ex)
                  {
                        TempData["message"] = ex.Message;
                        return View(student);
                  }


            }
      }
}
