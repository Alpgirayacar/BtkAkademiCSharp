using Microsoft.EntityFrameworkCore;

namespace CodeFirstBtkAkademi.Models
{
    public class BtkAkademiDbContext : DbContext
    {

        //SessionFactory Jpa EntityManager
        public BtkAkademiDbContext(DbContextOptions<BtkAkademiDbContext> options) : base(options)
        {

        }


        public DbSet<Movie> Movie { get; set; }



    }
}
