using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomersController : ApiController
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 0, Name = "Tom Cruise", Email = "tomcruise@gmail.com", Phone = "3322" },
            new Customer() {Id = 1, Name = "Robert Downy Jr", Email = "robert@gmail.com", Phone = "326"},
            new Customer() {Id = 2, Name = "Chris Patt", Email = "cpatt@gmail.com", Phone = "659" }
        };

        // GET: api/Customers
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET: api/Customers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customers
        public IHttpActionResult Post([FromBody]Customer customer)
        {
            if(ModelState.IsValid)
            {
                customers.Add(customer);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
