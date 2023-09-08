using BtkAkademiMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BtkAkademiMVC.Controllers
{
    public class MovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Movie> movieList = new List<Movie>();
            //rest apiye talepte bulunacak nesnemiz
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7276/api/Movies"))
                {
                    var gelenString = await response.Content.ReadAsStringAsync();
                    movieList = JsonConvert.DeserializeObject<List<Movie>>(gelenString);

                }

            }
            return View(movieList);
        }


        public async Task<IActionResult> DetayGetir(int id)
        {
            Movie movieDetail = new Movie();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7276/api/Movies/" + id))
                {
                    var gelenString = await response.Content.ReadAsStringAsync();
                    movieDetail = JsonConvert.DeserializeObject<Movie>(gelenString);

                }

            }
            return View(movieDetail);

        }


        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie)
        {
            Movie kaydedilmisFilm = new Movie();
            using (var httpClient = new HttpClient())
            {
                StringContent serializeEdilecekFilm = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:7276/api/Movies", serializeEdilecekFilm))
                {
                    string gelenKaydedilmisFilmJsonString = await response.Content.ReadAsStringAsync();
                    kaydedilmisFilm = JsonConvert.DeserializeObject<Movie>(gelenKaydedilmisFilmJsonString);
                    //ViewBag.Basarili = kaydedilmisFilm.Name + " Kaydedildi";
                }
            }

            return RedirectToAction("Index");

        }


       
    }
}
