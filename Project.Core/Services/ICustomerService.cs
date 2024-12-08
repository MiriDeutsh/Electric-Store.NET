using Project.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Services
{
    public interface ICustomerService
    {
        public List<Customer> GetAllCustomer();

        public Customer GetCustomer(int id);

        public Customer PostCustomer(Customer customer);

        public Customer PutCostumer(int id, Customer customer);

        public void DeleteCostumer(int id);
    }
}
