﻿using Project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface IOrderService
    {
        public IEnumerable<Order> GetAllOrder();

        public Order GetOrderById(int id);

        public Order PostOrder(Order order);

        public Order PutOrder(int id, Order order);

        public void DeleteOrder(int id);
    }
}
