using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete.EntityFramework
{
    public class AppDbContext:DbContext // sınıf -> ders -> derslik -> hoca
    {
        public DbSet<Derslik> Derslikler { get; set; } //MtoM classes  
        public DbSet<Class> Classes { get; set; } // MtoM teacher  
        public DbSet<Lesson> Lessons { get; set; } // MtoM teacher
        public DbSet<Teacher> Teachers { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\sqlite3\\damyo.db");
        }
    }
}
