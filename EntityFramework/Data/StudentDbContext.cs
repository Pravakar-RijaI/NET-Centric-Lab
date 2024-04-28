using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
            
        }

        public DbSet<StudentModel> Students { get; set; }
    }
}
