using Microsoft.EntityFrameworkCore;

namespace MigrationExample
{
    public class MigrationExampleDbContext:DbContext
    {
        public MigrationExampleDbContext(DbContextOptions<MigrationExampleDbContext> options ): base(options)   
        {
        
        }

        public DbSet<Person> PeopleTable { get; set; }   

    }
}
