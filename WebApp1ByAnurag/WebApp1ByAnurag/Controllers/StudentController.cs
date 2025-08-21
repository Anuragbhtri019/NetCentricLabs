using Microsoft.AspNetCore.Mvc;
using WebApp1ByAnurag.Models;

namespace WebApp1ByAnurag.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

   
        [HttpPost]
        
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Details", student);
            }
            return View(student);
        }

        public IActionResult Details(Student student)
        {
           
           
            return View(student);
        }
    }
}
