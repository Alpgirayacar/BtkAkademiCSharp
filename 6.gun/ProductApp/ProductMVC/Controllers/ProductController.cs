using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductAPI.Models;
using System.Net.Http;
using System.Text;

namespace ProductMVC.Controllers
{
    public class ProductController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Product> productList = new List<Product>();
            //rest apiye talepte bulunacak nesnemiz
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7165/api/Product"))
                {
                    var gelenString = await response.Content.ReadAsStringAsync();
                    productList = JsonConvert.DeserializeObject<List<Product>>(gelenString);

                }

            }
            return View(productList);


        }

        public async Task<IActionResult> Create ()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            Product kaydedilmisProduct = new Product();     
            using (var httpClient = new HttpClient())
            {
                StringContent serializeEdilecekProduct = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
                using (var response =await httpClient.PostAsync("https://localhost:7165/api/Product",serializeEdilecekProduct))
                {
                    string gelenKaydedilmisProductJsonString = await response.Content.ReadAsStringAsync();
                    kaydedilmisProduct = JsonConvert.DeserializeObject<Product>(gelenKaydedilmisProductJsonString);


                }

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id )
        {
            Product product;
            using (var httpClient = new HttpClient() )
            {
                using (var response = await httpClient.GetAsync("https://localhost:7165/api/Product/" + id))
                {
                    string jsonString = await response.Content.ReadAsStringAsync(); 
                    product= JsonConvert.DeserializeObject<Product>(jsonString);        
                   
                }

            }
            

            return View(product);  
        }

        [HttpPost]  
        public async Task<IActionResult> Edit (Product product)
        {
            StringContent serializeEdilecekProduct = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())


            {
                using (var response = await httpClient.PutAsync("https://localhost:7165/api/Product/",serializeEdilecekProduct))
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<Product>(jsonString);

                }

            }


            return RedirectToAction("Index");

        }


        public  async Task<IActionResult> Delete (int id)
        {
            using(var httpClient = new HttpClient()) {

                await httpClient.DeleteAsync("https://localhost:7165/api/Product/"+ id);

            }
            return RedirectToAction("Index");
        }
    }
}
