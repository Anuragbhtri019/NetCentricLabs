using Microsoft.EntityFrameworkCore;
namespace WebApp5ByAnurag.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Student> Students { get; set; }
    }
}
