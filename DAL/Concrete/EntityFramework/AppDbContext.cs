using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Concrete.EntityFramework
{
    public class AppDbContext:DbContext // sınıf -> ders -> derslik -> hoca
    {
        public DbSet<Derslik> Derslikler { get; set; }   
        public DbSet<Class> Classes { get; set; } 
        public DbSet<Lesson> Lessons { get; set; } 
        public DbSet<Teacher> Teachers { get; set; } 
        public DbSet<DersProgram> DersPrograms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\sqlite3\\damyo.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DersProgram>()// satırlar bir bütün halinde parimary keydir. 
                .HasKey(dp => new { dp.DersProgramId ,dp.ClassId, dp.DerslikId, dp.LessonId, dp.TeacherId, dp.DayId,dp.IntervalId });
                 // TODO: DersProgramId otomatik artan değil otomatik artması için hazır fonksiyon yaz . Sqlite "composite keys'de" otomatik arrtımı desteklemiyor 
        }
    }
}