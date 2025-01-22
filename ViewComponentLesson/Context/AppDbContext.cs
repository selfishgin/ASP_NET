using Microsoft.EntityFrameworkCore;
using ViewComponentLesson.Entities;

namespace ViewComponentLesson.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        public DbSet<Category> Categories { get; set; }
    }
}
