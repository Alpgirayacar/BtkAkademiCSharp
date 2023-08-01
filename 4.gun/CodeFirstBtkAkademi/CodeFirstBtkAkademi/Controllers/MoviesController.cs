using CodeFirstBtkAkademi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBtkAkademi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private BtkAkademiDbContext dbContext;  //connection, verileri çekicez, data gönderciez

        public MoviesController(BtkAkademiDbContext dbContext)
        {
            this.dbContext = dbContext;
        } 


        [HttpGet]
        public List<Movie>  FilmleriGetir()
        {
            List<Movie> movies = new List<Movie>();
            movies = dbContext.Movie.ToList(); // select * from Movie
            return movies;
        }

        //dışarıdan post tipinden bir json objesi göndereceğiz. 
        [HttpPost]
        public Movie FilmEkle(Movie movie) {

             dbContext.Movie.Add(movie);  //adonet kullanarak insert into 
            dbContext.SaveChanges(); // execute non query metodunu çağıracak
            return movie;
        }

        [HttpPut]
        public Movie FilmGuncelle(Movie movie)
        {
            dbContext.Movie.Update(movie);  //adonet kullanarak update sorgusu çalışacak 
            dbContext.SaveChanges(); // execute non query metodunu çağıracak
            return movie;
        }

        [HttpDelete("{id}")]
        public void  FilmSil(int id)
        {
            Movie silinecekFilm = dbContext.Movie.Find(id); //select * from Movie where Id=1
            dbContext.Movie.Remove(silinecekFilm);
            dbContext.SaveChanges();
        }


        [HttpGet("{id}")]
        public Movie FilmDetayGetir(int id)
        {
            Movie detayMovie = dbContext.Movie.Find(id); //select * from Movie where Id=1
            return detayMovie;
        }


    }
}
