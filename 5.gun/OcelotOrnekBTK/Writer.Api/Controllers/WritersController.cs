using Microsoft.AspNetCore.Mvc;
using Writer.Api.Repositories.Interfaces;

namespace Writer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly IWriterRepository writerRepository;


        public WritersController(IWriterRepository writerRepository)
        {
            this.writerRepository = writerRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(writerRepository.GetAll()); //select * from Writers json tüm data dönecek
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var writer = writerRepository.Get(id);
            if (writer == null)
                return NotFound();
            return Ok(writer);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.Writer writer)
        {
            var result = writerRepository.Insert(writer);
            return Created($"/get/{result.Id}", result);


        }

    }
}
