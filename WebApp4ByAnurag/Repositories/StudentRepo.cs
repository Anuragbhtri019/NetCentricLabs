using WebApp4ByAnurag.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApp4ByAnurag.Repositories
{
    public class StudentRepo : IRepository<Student>
    {
        private readonly StudentDbContext _context;

        public StudentRepo(StudentDbContext context)
        {
            _context = context;
        }

        // Create
        public void AddRecord(Student model)
        {
            _context.Students.Add(model);
            _context.SaveChanges();
        }

        // Delete
        public Student DeleteRecord(Student model)
        {
            var existingStudent = _context.Students.Find(model.Id);
            if (existingStudent != null)
            {
                _context.Students.Remove(existingStudent);
                _context.SaveChanges();
                return existingStudent;
            }
            return null;
        }

        // Read all
        public IEnumerable<Student> GetAllRecords()
        {
            return _context.Students.ToList();
        }

        // Read single
        public Student GetSingleRecord(int id)
        {
            return _context.Students.Find(id);
        }

        // Update
        public Student UpdateRecord(Student model)
        {
            var existingStudent = _context.Students.Find(model.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = model.Name;
                existingStudent.Marks = model.Marks;
                _context.SaveChanges();
                return existingStudent;
            }
            return null;
        }
    }
}
