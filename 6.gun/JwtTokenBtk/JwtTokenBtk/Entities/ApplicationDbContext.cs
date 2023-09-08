using Microsoft.EntityFrameworkCore;

namespace JwtTokenBtk.Entities
{
    public class ApplicationDbContext : DbContext
    {
        //Veritabanına hazırladığımız  modeli tablo olarak eklemesini söylüyoruz.
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        //Veritabanı olarak SQLite kullanacağımı söylüyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=jwtSampleBTK.db");

        //Veritabanı oluşturulurken dummy data ile oluşturulmasını istiyoruz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = 1,
                FirstName = "test",
                Username = "testUser",
                Password = "testPassword"
            });
        }
    }
}
