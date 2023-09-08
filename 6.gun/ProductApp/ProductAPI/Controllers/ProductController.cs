using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using System;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductDbContext dbContext;

       public ProductController(ProductDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }
        [HttpGet]
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products = dbContext.Products.ToList();
            return products;

        }
        [HttpPost]  

        public Product AddProduct (Product product) {
            dbContext.Add(product);
            dbContext.SaveChanges();
            return product;

        }

        [HttpPut]
        public Product UpdateProduct (Product product)
        {
            dbContext.Update(product);  
            dbContext.SaveChanges();    
            return product;
        }

        [HttpDelete("{id}")]    
        public void DeleteProduct(int id)
        {
            var silinecekProduct = dbContext.Products.Find(id);
            dbContext.Products.Remove(silinecekProduct);
            dbContext.SaveChanges();

        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            var product = dbContext.Products.Find(id);
            return product;

        }
    }
}
