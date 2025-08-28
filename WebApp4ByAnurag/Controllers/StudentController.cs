using Microsoft.AspNetCore.Mvc;
using WebApp4ByAnurag.Models;
using WebApp4ByAnurag.Repositories;

namespace WebApp4ByAnurag.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepository<Student> _repo;

        public StudentController(IRepository<Student> repo)
        {
            _repo = repo;
        }

        // GET: /Student
        public IActionResult Index()
        {
            IEnumerable<Student> students = _repo.GetAllRecords();
            return View(students);
        }

        // GET: /Student/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                _repo.AddRecord(std);
                return RedirectToAction(nameof(Index));
            }
            return View(std);
        }

        // GET: /Student/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _repo.GetSingleRecord(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: /Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student std)
        {
            if (!ModelState.IsValid)
                return View(std);

            var updated = _repo.UpdateRecord(std);
            if (updated == null)
                return NotFound();

            return RedirectToAction(nameof(Index));
        }

        // GET: /Student/Delete/5
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _repo.GetSingleRecord(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: /Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _repo.GetSingleRecord(id);
            if (student == null)
                return NotFound();

            _repo.DeleteRecord(student);
            return RedirectToAction(nameof(Index));
        }

        // GET: /Student/Details/5
        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = _repo.GetSingleRecord(id);
            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
