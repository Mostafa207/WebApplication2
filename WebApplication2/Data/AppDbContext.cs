using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public class AppDbContext :DbContext
    {
        public DbSet<user> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 
    }
}
