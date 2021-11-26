using KMart.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KMart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly KMartDBContext db;

        public ProductController()
        {
            db = new KMartDBContext();
        }

        [HttpGet]
        [Route("GetProducts")]
        public List<Product> GetProducts()
        {
            List<Product> products = db.Products.ToList();
            return products;
        }


        [HttpGet]
        [Route("GetProduct/{id}")]
        public Product GetProduct(int id)
        {
            Product prod = db.Products.SingleOrDefault(p => p.PId == id);
            return prod;
        }

        [HttpPost]
        [Route("AddProduct")]
        public string AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();

            return "Product added";
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public void DeleteProduct(int id)
        {
            Product p = db.Products.SingleOrDefault(p => p.PId == id);
            db.Products.Remove(p); 
            db.SaveChanges();
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public string EditProduct(Product p)
        {
            db.Products.Update(p);
            db.SaveChanges();
            return "Product updated";
        }


    }
}
