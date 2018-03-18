using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : ApiController
    {
        static List<Product> products = new List<Product>()
        {
            new Product() {Id = 0, ProductName = "Apple", Price = 20 },
            new Product() {Id = 1, ProductName = "Banana", Price = 40 },
            new Product() {Id = 2, ProductName = "Orange", Price = 60 }
        };
        // GET: api/Products
        public IHttpActionResult Get()
        {
            return Ok(products);
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return products[id];
        }

        // POST: api/Products
        public HttpResponseMessage Post([FromBody]Product product)
        {
            products.Add(product);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]Product product)
        {
            products[id] = product;
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
            products.RemoveAt(id);
        }
    }
}
