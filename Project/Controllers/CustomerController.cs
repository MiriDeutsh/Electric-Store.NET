
using Microsoft.AspNetCore.Mvc;
using Project.Core.Model;
using Project.Core.Services;
using Project.Data;
using System.Diagnostics.Metrics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _CustomerServise;
        public CustomerController(ICustomerService CustomerServise)
        {
            _CustomerServise = CustomerServise;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return _CustomerServise.GetAllCustomer();
        }


        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _CustomerServise.Get(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public Customer Post([FromBody] Customer value)
        {
            _CustomerServise.PostCustomer(value);
            return value;
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public Customer Put(int id, [FromBody] Customer value)
        {
            return _CustomerServise.PutCustomer(id, value);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _CustomerServise.DeleteCustomer(id);
        }
    }
}
