using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete.EntityFramework
{
    public class AppDbContext:DbContext
    {
        public DbSet<DerslikEntity> Derslikler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\sqlite3\\damyo.db");
        }
    }
}
