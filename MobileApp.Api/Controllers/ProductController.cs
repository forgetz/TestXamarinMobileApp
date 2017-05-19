using Microsoft.AspNetCore.Mvc;
using MobileApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApp.Api.Controllers
{
    [Route("tables/[controller]")]
    public class ProductController : Controller
    {
        ForgetzDbContext db;
        public ProductController(ForgetzDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return new Product();
        }

        [HttpPost]
        public Product Post([FromBody]Product product)
        {
            db.Add(product);
            db.SaveChanges();
            return product;
        }

        [HttpPut]
        public Product Put([FromBody]Product product)
        {
            db.Update(product);
            db.SaveChanges();
            return product;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = db.Products.Where(p => p.Id == id).Single();
            db.Remove(product);
            db.SaveChanges();
        }

    }
}
