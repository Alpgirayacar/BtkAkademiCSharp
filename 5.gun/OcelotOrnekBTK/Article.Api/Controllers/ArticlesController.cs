using Article.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        //Repository Design Pattern Nedir 
        private readonly IArticleRepository articleRepository;

        //Constructor Injection  Dependency Injection 
        //ArticlesController class ından bir nesne oluşturcağın zaman
        // IArticleRepository interface ini implement etmiş hangi obje gönderirsem
        // onun da nesnesini oluştur anlamına gelir
        public ArticlesController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(articleRepository.GetAll());// Tüm makalelelr dönecek json döncek
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var detailArticle = articleRepository.Get(id);
            if (detailArticle is null)
            {
                return NotFound(); // ilgili detay kayıt bulunamadı
            }
            return Ok(detailArticle);//200 kodu döner select * from Article wher Id=id
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var silinecekArticle = articleRepository.Delete(id);
            if (silinecekArticle == 0)
                return NotFound(); // 404
            return NoContent();
        }
    }
}
