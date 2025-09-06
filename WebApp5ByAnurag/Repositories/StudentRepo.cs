using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using WebApp5ByAnurag.Models;
using WebApp5ByAnurag.Repositories;

namespace WebApp4ByAnurag.Repositories
{
    public class StudentRepo : IRepository<Student>
    {
        private readonly AppDbContext _context;

        public StudentRepo(AppDbContext context)
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
                existingStudent.Age = model.Age;
                existingStudent.Email = model.Email;
                _context.SaveChanges();
                return existingStudent;
            }
            return null;
        }
    }
}