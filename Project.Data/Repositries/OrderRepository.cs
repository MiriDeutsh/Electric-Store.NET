using Project.Core.Model;
using Project.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositries
{
    public class OrderRepository: IOrderRepository
    {
        static int counter = 0;
        private DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Order> GetAll()
        {
            return _context.Orders;
        }
        public Order GetById(int id)
        {
            var index = _context.Orders.ToList().FindIndex(o => o.OrderId == id);
            return _context.Orders.ToList()[index];
        }
        public Order Post(Order order)
        {
            order.OrderId = counter++;
            _context.Orders.ToList().Add(order);
            _context.SaveChanges();
            return order;
        }
        public Order Put(int id, Order order)
        {
            int index = _context.Orders.ToList().FindIndex(o => o.OrderId == id);
            _context.Orders.ToList()[index].CustomerId = order.CustomerId;
            _context.Orders.ToList()[index].OrderDate = order.OrderDate;
            _context.Orders.ToList()[index].TotalPrice = order.TotalPrice;
            _context.SaveChanges();
            return _context.Orders.ToList()[index];
        }
        public void Delete(int id)
        {
            int index = _context.Orders.ToList().FindIndex(o => o.OrderId == id);
            _context.Orders.ToList().Remove(_context.Orders.ToList()[index]);
            _context.SaveChanges();
        }
    }
}
