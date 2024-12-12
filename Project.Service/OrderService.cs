using Project.Core.Model;
using Project.Core.Repositories;

using Project.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class OrderService: IOrderService
    {
        private IOrderRepository _OrderRepository;
        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }
        public IEnumerable<Order> GetAllOrder()
        {
            return _OrderRepository.GetAll();

        }
        public Order GetOrderById(int id)
        {
            return _OrderRepository.GetById(id);
        }
        public Order PostOrder(Order order)
        {
            return _OrderRepository.Post(order);
        }
        public Order PutOrder(int id, Order order)
        {
            return _OrderRepository.Put(id, order);
        }
        public void DeleteOrder(int id)
        {
            _OrderRepository.Delete(id);
        }
    }
}
