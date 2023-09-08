using Microsoft.AspNetCore.Mvc;

namespace MigrationExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        MigrationExampleDbContext migrationExampleDbContext;
        public HomeController(MigrationExampleDbContext migrationExampleDbContext)
        {
            this.migrationExampleDbContext = migrationExampleDbContext;
        }

        [HttpGet]

       public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people= migrationExampleDbContext.PeopleTable.ToList();  
            return people;  

        }
    }
}
