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
    public class ProductController : ControllerBase
    {
        private IProductService _ProductServise;
        public ProductController(IProductService ProductServise)
        {
            _ProductServise = ProductServise;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _ProductServise.GetAllProduct();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _ProductServise.GetProduct(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public Product Post([FromBody] Product value)
        {
            _ProductServise.PostProducts(value);
            return value;
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] Product value)
        {
            return _ProductServise.PutProduct(id,index);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ProductServise.DeleteProducts(id);
        }

    }
}
