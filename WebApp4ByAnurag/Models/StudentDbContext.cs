using Microsoft.EntityFrameworkCore;
using WebApp4ByAnurag.Models;

namespace WebApp4ByAnurag.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}
