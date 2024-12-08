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
    public class CustomerService: ICustomerService
    {
        private ICustomeRepository _CustomerRepository;
        public CustomerService(ICustomeRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }
        public List<Customer> GetAllCustomer()
        {
            return _CustomerRepository.GetAll();

        }
        public Customer GetCustomer(int id)
        {
            return _CustomerRepository.Get(id);
        }
        public Customer PostCustomer(Customer customer)
        {
            return _CustomerRepository.Post(customer);
        }
        public Customer PutCustomer(int id, Customer customer)
        {
            return _CustomerRepository.Put(id, customer);
        }
        public void DeleteCustomer(int id)
        {
            _CustomerRepository.Delete(id);
        }
    }
}
