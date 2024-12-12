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
        public IEnumerable<Customer> GetAllCustomer();

        public Customer GetCustomerById(int id);

        public Customer PostCustomer(Customer customer);

        public Customer PutCustomer(int id, Customer customer);

        public void DeleteCustomer(int id);
    }
}
