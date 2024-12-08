using Microsoft.AspNetCore.Mvc;
using Project.Core.Model;
using Project.Core.Services;
using Project.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _OrderServise;
        public OrderController(IOrderService OrderServise)
        {
            _OrderServise = OrderServise;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return _OrderServise.GetAllOrder();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _OrderServise.GetOrder(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public Order Post([FromBody] Order value)
        {
            _OrderServise.PostOrder(value);
            return value;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public Order Put(int id, [FromBody] Order value)
        {
            return _OrderServise.PutOrder(id,value);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _OrderServise.DeleteOrder(id);
        }

    }
}
