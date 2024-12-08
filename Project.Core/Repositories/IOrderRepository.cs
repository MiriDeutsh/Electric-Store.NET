using Project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
    public interface IOrderRepository
    {
        public List<Order> GetAll();

        public Order Get(int id);

        public Order Post(Order value);

        public Order Put(int id, Order value);

        public void Delete(int id);
    }
}
