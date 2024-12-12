using Project.Core.Model;
using Project.Core.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositries
{
    public class CustomerRepository:ICustomeRepository
    {
        static int counter = 0;
        private DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers;
        }

        public Customer GetById(int id)
        {
            var index = _context.Customers.ToList().FindIndex(c => c.CustomerId == id);
            return _context.Customers.ToList()[index];
        }

        public Customer Post(Customer customer)
        {
            customer.CustomerId = counter++;
            _context.Customers.ToList().Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customer Put(int id, Customer customer)
        {
            int index = _context.Customers.ToList().FindIndex(c => c.CustomerId == id);
            _context.Customers.ToList()[index].CustomerName = customer.CustomerName;
            _context.Customers.ToList()[index].Address = customer.Address;
            _context.Customers.ToList()[index].City = customer.City;
            _context.Customers.ToList()[index].Email = customer.Email;
            _context.SaveChanges();
            return _context.Customers.ToList()[index];
        }

        public void Delete(int id)
        {
            var index = _context.Customers.ToList().FindIndex(c => c.CustomerId == id);
            _context.Customers.ToList().Remove(_context.Customers.ToList()[index]);
            _context.SaveChanges();
        }
    }
}
